using CommunityToolkit.Mvvm.Messaging;
using ListViewSample.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace ListViewSample.ViewModels
{
  internal class LoadingViewModel : ViewModelBase
  {
    private double loadingPercent = 0;
    public double LoadingPercent
    {
      get => loadingPercent;
      set => SetProperty(ref loadingPercent, value);
    }

    public LoadingViewModel()
    {

    }

    private DispatcherTimer timer = null!;

    protected override void OnLoad()
    {
      base.OnLoad();
      timer = new DispatcherTimer();
      timer.Interval = TimeSpan.FromMilliseconds(10);
      timer.Tick += OnTick;
      timer.Start();
    }

    protected override void OnUnload()
    {
      base.OnUnload();

      if (timer != null)
      {
        timer.Stop();
      }
    }
    private void OnTick(object? sender, EventArgs e)
    {
      Application.Current.Dispatcher.Invoke(() =>
      {
        LoadingPercent += 0.1*0.1/150;
        if (loadingPercent >= 150)
        {
          WeakReferenceMessenger.Default.Send(new NavigationMessage("HomeView.xaml"));
        }
      });
    }

  }
}
