using System;
using System.Collections.Generic;
using Android.Content;
using Android.Support.V4.App;
using MvvmCross.Droid.Support.V4;

namespace FragmentTabsTest
{
  public class SimpleSearchTabAdapter : MvxCachingFragmentStatePagerAdapter
  {
    public SimpleSearchTabAdapter(Context context, FragmentManager fragmentManager, IEnumerable<FragmentInfo> fragments) 
      : base(context, fragmentManager, fragments)
    {
    }

    public override int GetItemPosition(Java.Lang.Object objectValue)
    {
      return PositionNone;
    }
  }
}
