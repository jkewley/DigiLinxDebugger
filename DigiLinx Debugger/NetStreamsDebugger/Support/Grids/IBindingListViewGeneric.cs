using System.ComponentModel;

namespace NetStreamsDebugger.Support.Grids {
    public interface IBindingListViewGeneric : IBindingListView, IRaiseItemChangedEvents {
        void RefreshFilter();
    }
}