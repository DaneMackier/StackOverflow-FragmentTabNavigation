using Android.App;
using Android.OS;
using FragmentTabsTest.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Droid.Views;
using MvvmCross.Platform;

namespace FragmentTabsTest.Views
{
  [Activity(Label = "View for MainViewModel")]
  public class MainView : MvxCachingFragmentCompatActivity<MainViewModel>
  {
    protected override void OnCreate(Bundle bundle)
    {
      base.OnCreate(bundle);
      SetContentView(Resource.Layout.MainView);

      var presenter = Mvx.Resolve<IMvxAndroidViewPresenter>() as AndroidViewPresenter;
      presenter.SetFragmentManager(SupportFragmentManager);
    }
  }
}
