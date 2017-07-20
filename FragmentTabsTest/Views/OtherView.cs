using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using FragmentTabsTest.Core.ViewModels;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Views;

namespace FragmentTabsTest.Views
{
  [MvxFragmentAttribute(typeof(MainViewModel), Resource.Id.fragmentFrame, AddToBackStack = true)]
  [Register("fragmenttabstest.views.OtherView")]
  public class OtherView : MvxFragment<OtherViewModel>
  {
    public OtherView()
    {
      this.RetainInstance = true;
    }

    public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
    {
      var ignored = base.OnCreateView(inflater, container, savedInstanceState);
      return this.BindingInflate(Resource.Layout.OtherView, null);
    }
  }
}
