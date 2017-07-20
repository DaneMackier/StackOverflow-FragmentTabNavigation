using System.Collections.Generic;
using System.Reflection;
using Android.Support.V4.App;
using MvvmCross.Droid.Shared.Presenter;

namespace FragmentTabsTest
{
  public class AndroidViewPresenter : MvxFragmentsPresenter
  {
    private FragmentManager _fragmentManager;
    public FragmentManager FragmentManager
    {
      get
      {
        return _fragmentManager;
      }
    }

    public AndroidViewPresenter(
      IEnumerable<Assembly> assemblies)
      : base(assemblies)
    {     
    }

    public void SetFragmentManager(FragmentManager fragmentManager)
    {
      _fragmentManager = fragmentManager;
    }
  }
}