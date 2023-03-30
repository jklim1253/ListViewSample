using CommunityToolkit.Mvvm.Messaging;
using ListViewSample.Messages;
using ListViewSample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewSample.ViewModels
{
  internal class MainViewModel : ViewModelBase
  {
    private string currentView = string.Empty;
    public string CurrentView
    {
      get => currentView;
      set => SetProperty(ref currentView, value);
    }


    public MainViewModel(ISettingService setting) : base(setting)
    {
      CurrentView = "LoadingView.xaml";
    }

    protected override void OnLoad()
    {
      base.OnLoad();
      WeakReferenceMessenger.Default.Register<NavigationMessage>(this, OnNavigateMessage);
    }

    private void OnNavigateMessage(object recipient, NavigationMessage message)
    {
      CurrentView = message.Value;
    }
  }
}
