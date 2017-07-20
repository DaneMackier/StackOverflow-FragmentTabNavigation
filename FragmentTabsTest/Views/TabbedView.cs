using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Views;
using FragmentTabsTest.Core.ViewModels;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Views;
using MvvmCross.Platform;

namespace FragmentTabsTest.Views
{
  [MvxFragmentAttribute(typeof(MainViewModel), Resource.Id.fragmentFrame, AddToBackStack = true)]
  [Register("fragmenttabstest.views.TabbedView")]
  public class TabbedView : MvxFragment<TabbedViewModel>
  {
    public TabbedView()
    {
      this.RetainInstance = true;
    }


    //[BindView(Resource.Id.main_view_pager)]
    //private ViewPager _fragmentPager;

    //[BindView(Resource.Id.main_tablayout)]
    //private TabLayout _tabLayout;

    public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
    {
      var ignored = base.OnCreateView(inflater, container, savedInstanceState);

      var view = this.BindingInflate(Resource.Layout.TabbedView, null);

      var fragmentPager = view.FindViewById<ViewPager>(Resource.Id.main_view_pager);
      var tabLayout = view.FindViewById<TabLayout>(Resource.Id.main_tablayout);

      var fragments = GetTabFragments();
      var presenter = Mvx.Resolve<IMvxAndroidViewPresenter>() as AndroidViewPresenter;
      var adapter = new SimpleSearchTabAdapter(Context, presenter.FragmentManager, fragments);
      fragmentPager.Adapter = adapter;

      tabLayout.SetupWithViewPager(fragmentPager);

      return view;
    }

    private List<MvxCachingFragmentStatePagerAdapter.FragmentInfo> GetTabFragments()
    {
      var fragments = new List<MvxCachingFragmentStatePagerAdapter.FragmentInfo>();

      foreach (var tabViewModel in ViewModel.TabViewModels)
        fragments.Add(new MvxCachingFragmentStatePagerAdapter.FragmentInfo(GetTabNameFromViewModel(tabViewModel),
                                                                           GetViewTypeFromViewModel(tabViewModel),
                                                                           tabViewModel));

      return fragments;
    }


    private System.Type GetViewTypeFromViewModel(TabChildViewModel viewModel)
    {
      return typeof(TabChildView);
    }

    private string GetTabNameFromViewModel(TabChildViewModel viewModel)
    {
      return viewModel.Name;
    }
  }
}
