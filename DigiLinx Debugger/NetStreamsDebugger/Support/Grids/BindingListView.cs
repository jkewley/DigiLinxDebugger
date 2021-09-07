/*
 * File Name: 
 *          BindingListView.cs
 * 
 * Namespace Located In:
 *          System.ComponentModel
 * 
 * Purpose:
 *          This offers a concrete class that implements the IBindingListView 
 *          interface.
 * 

 * Notes:
 *          This class is largely based on the work done in the book          
 *          Data Binding with Windows Forms 2.0 : Programming 
 *          Smart Client Data Applications with .NET (Microsoft Net Development 
 *          Series) by Brian Noyes (ISBN: 032126892X).
 *          Predicate-of-T-based filtering was added by Rylan Barnes.
 *
 *          Added the ability to have a "live filtered list" where items can be added while the 
 *          filter is applied without losing the original collection, and without violating
 *          the filter rules
 * 
 * Found at : http://dallas.sark.com/SarkBlog/rbarnes/archive/2006/07/09/3792.aspx
 * Another good reference: http://msdn2.microsoft.com/en-us/library/ms951295.aspx
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace NetStreamsDebugger.Support.Grids {
    public class BindingListView<T> : BindingList<T>, IBindingListViewGeneric, IEnumerable<T> {
        private Predicate<T> filterPredicate = null;
        private string filterString = null;
        private bool isFiltered = false;
        private bool isSorted = false;
        private ListSortDescriptionCollection sortDescriptions = new ListSortDescriptionCollection();
        private ListSortDirection sortDirection = ListSortDirection.Ascending;
        private PropertyDescriptor sortProperty = null;
        private List<T> theOriginalCollection = new List<T>();

        public BindingListView() {}
        public BindingListView(IList<T> list) : base(list) {}

        #region Searching

        protected override bool SupportsSearchingCore { get { return true; } }

        protected override int FindCore(PropertyDescriptor property, object key) {
            // Simple iteration:

            for(int i = 0; i < Count; i++) {
                T item = this[i];

                if(property.GetValue(item).Equals(key)) return i;
            }

            return -1; // Not found

            // Alternative search implementation
            // using List.FindIndex:
            //Predicate<T> pred = delegate(T item)
            //{
            // return (property.GetValue(item).Equals(key))
            //};

            //List<T> list = Items as List<T>;
            //if (list == null)
            // return -1;
            //return list.FindIndex(pred);
        }

        #endregion

        #region Sorting Implementation

        protected override bool SupportsSortingCore { get { return true; } }

        protected override bool IsSortedCore { get { return isSorted; } }

        protected override ListSortDirection SortDirectionCore { get { return sortDirection; } }

        protected override PropertyDescriptor SortPropertyCore { get { return sortProperty; } }

        public void ApplySort(ListSortDescriptionCollection sorts) {
            sortProperty = null;
            sortDescriptions = sorts;
            SortComparer<T> comparer = new SortComparer<T>(sorts);
            ApplySortInternal(comparer);
        }

        public ListSortDescriptionCollection SortDescriptions { get { return sortDescriptions; } }

        public bool SupportsAdvancedSorting { get { return true; } }

        protected override void ApplySortCore(PropertyDescriptor property, ListSortDirection direction) {
            sortDirection = direction;
            sortProperty = property;
            SortComparer<T> comparer = new SortComparer<T>(property, direction);
            ApplySortInternal(comparer);
        }

        private void ApplySortInternal(SortComparer<T> comparer) {
            if(theOriginalCollection.Count == 0)
                theOriginalCollection.AddRange(this);

            List<T> listRef = Items as List<T>;

            if(listRef == null) return;
            listRef.Sort(comparer);
            isSorted = true;
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        protected override void RemoveSortCore() {
            if(!isSorted) return;

            Clear();
            foreach(T item in theOriginalCollection)
                Add(item);

            theOriginalCollection.Clear();
            sortProperty = null;
            sortDescriptions = null;
            isSorted = false;
        }

        #endregion

        #region Filtering

        public Predicate<T> FilterPredicate {
            get { return filterPredicate; }

            set {
                filterString = null;
                filterPredicate = value;
                isFiltered = true;
                UpdateFilter();
            }
        }

        public void RefreshFilter() {
            UpdateFilterFromPredicate();
        }

        public bool SupportsFiltering { get { return true; } }

        public string Filter {
            get { return filterString; }

            set {
                filterPredicate = null;
                filterString = value;
                isFiltered = true;
                UpdateFilter();
            }
        }

        public void RemoveFilter() {
            if(!isFiltered) return;

            lock(Items) {
                filterString = null;
                filterPredicate = null;
                isFiltered = false;

                if(theOriginalCollection.Count < 1000) {
                    Clear();
                    foreach(T item in theOriginalCollection)
                        Add(item);
                    theOriginalCollection.Clear();
                } else {
                    ClearItems();
                    foreach(T item in theOriginalCollection)
                        Items.Add(item);
                    theOriginalCollection.Clear();
                    if(!isSorted)
                        OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, 0));
                }
            }
            if(isSorted)
                ApplySortCore(sortProperty, sortDirection);
        }

        protected virtual void UpdateFilter() {
            if(theOriginalCollection.Count == 0)
                theOriginalCollection.AddRange(this);

            if(filterString != null) UpdateFilterFromString();

            else if(filterPredicate != null) UpdateFilterFromPredicate();

            else RemoveFilter();
        }

        private void UpdateFilterFromString() {
            int equalsPos = filterString.IndexOf('=');

            // Get property name
            string propName = filterString.Substring(0, equalsPos).Trim();

            // Get filter criteria
            string criteria = filterString.Substring(equalsPos + 1, filterString.Length - equalsPos - 1).Trim();

            // Strip leading and trailing quotes
            if(criteria.Contains("\"") || criteria.Contains("'")) criteria = criteria.Substring(1, criteria.Length - 2);

            // Get a property descriptor for the filter property
            PropertyDescriptor propDesc = TypeDescriptor.GetProperties(typeof(T))[propName];
            List<T> currentCollection = new List<T>(this);
            Clear();

            foreach(T item in currentCollection) {
                object value = propDesc.GetValue(item);
                if(value.ToString() == criteria) Add(item);
            }
        }

        private void UpdateFilterFromPredicate() {
            Items.Clear();
            foreach(T item in theOriginalCollection) {
                if(FilterPredicate(item))
                    Items.Add(item);
            }

            if(isSorted) ApplySortCore(sortProperty, sortDirection);
            else OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, 0));
        }

        #endregion

        #region IBindingListViewGeneric Members

        public new bool AllowNew { get { return CheckReadOnly(); } }
        public new bool AllowRemove { get { return CheckReadOnly(); } }

        public bool RaisesItemChangedEvents { get { return true; } }

        #endregion

        #region IEnumerable<T> Members

        IEnumerator<T> IEnumerable<T>.GetEnumerator() {
            foreach(T aValue in Items) yield return aValue;
        }

        #endregion

        /// <summary>
        /// Can't add or remove if a filter or sort is applied
        /// </summary>
        /// <returns></returns>
        private bool CheckReadOnly() {
            return (isSorted || isFiltered);
        }

        protected override void InsertItem(int index, T item) {
            foreach(PropertyDescriptor propDesc in TypeDescriptor.GetProperties(item)) {
                if(propDesc.SupportsChangeEvents)
                    propDesc.AddValueChanged(item, OnItemChanged);
            }
            //inserting when a filter might be applied. Add everything to theOriginalCollection, and add to List if it meets filter criteria
            if(isFiltered) {
                theOriginalCollection.Add(item);
                if(filterPredicate != null) {
                    if(FilterPredicate(item))
                        base.InsertItem(index, item);
                } else base.InsertItem(index, item);
            } else base.InsertItem(index, item);
        }

        protected override void RemoveItem(int index) {
            T item = Items[index];
            PropertyDescriptorCollection propDescs = TypeDescriptor.GetProperties(item);
            foreach(PropertyDescriptor propDesc in propDescs) {
                if(propDesc.SupportsChangeEvents)
                    propDesc.RemoveValueChanged(item, OnItemChanged);
            }
            base.RemoveItem(index);
        }

        protected void OnItemChanged(object sender, EventArgs args) {
            int index = Items.IndexOf((T) sender);
            OnListChanged(new ListChangedEventArgs(ListChangedType.ItemChanged, index));
        }
    }
}