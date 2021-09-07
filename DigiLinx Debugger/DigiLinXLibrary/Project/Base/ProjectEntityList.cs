using System.Collections;
using System.Collections.Generic;

namespace DigiLinXLibrary.Project.Base {
    public class ProjectEntityList<T> : ProjectEntity, IEnumerable<T> where T : ProjectEntity {
        internal SortedList<int, T> theEntityList;

        public ProjectEntityList() {
            theEntityList = new SortedList<int, T>();
        }

        #region IEnumerable<T> Members

        IEnumerator<T> IEnumerable<T>.GetEnumerator() {
            foreach(T aValue in theEntityList.Values) {
                yield return aValue;
            }
        }

        public IEnumerator GetEnumerator() {
            return ((IEnumerable<T>) this).GetEnumerator();
        }

        #endregion
    }
}