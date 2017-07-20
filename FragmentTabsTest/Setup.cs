using Android.Content;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using FragmentTabsTest.Core;
using System.Collections.Generic;
using System.Reflection;
using MvvmCross.Platform;
using MvvmCross.Droid.Views;

namespace FragmentTabsTest
{
  public class Setup : MvxAndroidSetup
  {
    public Setup(Context applicationContext) : base(applicationContext)
    {
    }

    protected override IMvxApplication CreateApp()
    {
      return new App();
    }

    protected override IMvxTrace CreateDebugTrace()
    {
      return new DebugTrace();
    }

    protected override IMvxAndroidViewPresenter CreateViewPresenter()
    {
      var viewPresenter = new AndroidViewPresenter(AndroidViewAssemblies);;
      Mvx.RegisterSingleton<IMvxAndroidViewPresenter>(viewPresenter);
      return viewPresenter;
    }

    protected override IEnumerable<Assembly> AndroidViewAssemblies => new List<Assembly>(base.AndroidViewAssemblies)
    {
        typeof(Android.Support.V7.Widget.Toolbar).Assembly,
        typeof(Android.Support.V4.View.ViewPager).Assembly
    };
  }
}
