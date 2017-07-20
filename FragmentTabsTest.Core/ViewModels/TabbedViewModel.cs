using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace FragmentTabsTest.Core.ViewModels
{
  public class TabbedViewModel : MvxViewModel
  {
    public string AdvancedSearchButtonText { get { return "OTHERVIEW"; } }

    public List<TabChildViewModel> TabViewModels { get; set; }

    public event EventHandler ShowingViewAgain;

    private string _searchText;
    public string SearchText
    {
      get { return _searchText; }
      set
      {
        _searchText = value;
        RaisePropertyChanged(() => SearchText);
      }
    }

    public MvxCommand OtherViewCommand { get { return new MvxCommand(ShowOtherView); } }

    public TabbedViewModel()
    {
      TabViewModels = new List<TabChildViewModel>()
        {
          new TabChildViewModel("Child 1"),
          new TabChildViewModel("Child 2"),
          new TabChildViewModel("Child 3")
        };
    }

    private void ShowOtherView()
    {
      ShowViewModel<OtherViewModel>();
    }
  }
}