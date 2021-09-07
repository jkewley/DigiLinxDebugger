using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Windows.Forms;
using NetStreamsDebugger.Support;
using NetStreamsDebugger.Support.Grids;

namespace NetStreamsDebugger {
    public partial class DebuggerForm {
        private List<Filter> theExcludedFilters;
        private List<Filter> theIncludedFilters;
        private List<Filter> theRegexFilterList;

        /// <summary>
        /// Rehydrate the saved filter list from the config section
        /// </summary>
        private void ReadInSavedFilters() {
            FiltersConfigurationSection section = (FiltersConfigurationSection) ConfigurationManager.GetSection("FiltersList");
            theRegexFilterList = new List<Filter>();
            if(section != null) {
                foreach(SavedFilter aSavedFilter in section.Filters)
                    theRegexFilterList.Add(new Filter(aSavedFilter.Name, aSavedFilter.Pattern, aSavedFilter.Exclude, aSavedFilter.Include));
            }
            theIncludedFilters = theRegexFilterList.FindAll(delegate(Filter aFilter) { return aFilter.Include; });
            theExcludedFilters = theRegexFilterList.FindAll(delegate(Filter aFilter) { return aFilter.Exclude; });
        }

        /// <summary>
        /// Reapplies all view filters and updates the UI to reflect the new rules
        /// </summary>
        private void DoApplyAllFilters() {
            if(allBindingListViews != null) {
                foreach(IBindingListViewGeneric view in allBindingListViews) view.RefreshFilter();
                ScrollAndUpdateGrids();
                UpdateFilterStatusLabel();
            }
        }

        /// <summary>
        /// Resets the Include and Exclude properties for all filters to false
        /// </summary>
        private void ResetIncludeExcludeFilters() {
            theIncludedFilters.Clear();
            theExcludedFilters.Clear();

            theRegexFilterList.ForEach(delegate(Filter aFilter) {
                aFilter.Include = false;
                aFilter.Exclude = false;
            });
        }

        /// <summary>
        /// Open the form that allows for management of Regular Expression filters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickManageFiltersLink(object sender, LinkLabelLinkClickedEventArgs e) {
            ManageFilters aManageFilters = new ManageFilters(filterBindingSource);
            aManageFilters.ShowDialog();

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            theRegexFilterList.Clear();
            foreach(Filter aFilter in filterBindingSource) if(aFilter.Name != null) theRegexFilterList.Add(aFilter);
            theIncludedFilters = theRegexFilterList.FindAll(delegate(Filter aFilter) { return aFilter.Include; });
            theExcludedFilters = theRegexFilterList.FindAll(delegate(Filter aFilter) { return aFilter.Exclude; });
            config.Save();

            DoApplyAllFilters();
            return;
        }

        private void ClickClearFiltersLink(object sender, LinkLabelLinkClickedEventArgs e) {
            ResetIncludeExcludeFilters();
            DoApplyAllFilters();
        }

        private void UpdateFilterStatusLabel() {
            if(theRegexFilterList.Count == 0) {
                lblIncludedList.Text = "none";
                lblExcludedList.Text = "none";
                return;
            }

            if(theRegexFilterList.Exists(delegate(Filter aFilter) { return aFilter.Include; })) {
                StringBuilder aBuilder = new StringBuilder();
                theRegexFilterList.ForEach(delegate(Filter aFilter) { if(aFilter.Include) aBuilder.Append(aFilter.Name + ", "); });
                aBuilder.Remove(aBuilder.Length - 2, 2);
                lblIncludedList.Text = aBuilder.ToString();
            } else lblIncludedList.Text = "none";

            if(theRegexFilterList.Exists(delegate(Filter aFilter) { return aFilter.Exclude; })) {
                StringBuilder aBuilder = new StringBuilder();
                theRegexFilterList.ForEach(delegate(Filter aFilter) { if(aFilter.Exclude) aBuilder.Append(aFilter.Name + ", "); });
                aBuilder.Remove(aBuilder.Length - 2, 2);
                lblExcludedList.Text = aBuilder.ToString();
            } else lblExcludedList.Text = "none";
        }

        private void BindFilterList() {
            filterBindingSource.Clear();
            foreach(Filter aFilter in theRegexFilterList)
                filterBindingSource.Add(aFilter);
        }
    }
}