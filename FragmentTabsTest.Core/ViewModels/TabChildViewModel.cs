using System;
using MvvmCross.Core.ViewModels;

namespace FragmentTabsTest.Core.ViewModels
{
  public class TabChildViewModel : MvxViewModel
  {
    public TabChildViewModel(string name = "default")
    {
      Name = name;
    }

    private string _name;
    public string Name
    {
      get { return _name; }
      set
      {
        _name = value;
        RaisePropertyChanged(() => Name);
      }
    }
  }
}
