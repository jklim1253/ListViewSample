using CommunityToolkit.Mvvm.DependencyInjection;
using ListViewSample.Extensions;
using ListViewSample.Views;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ListViewSample
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    private readonly IHost host;

    public App()
    {
      host = Host.CreateDefaultBuilder()
                 .SampleConfigure()
                 .Build();

      Ioc.Default.ConfigureServices(host.Services);

      host.RunAsync();
    }

    protected override void OnStartup(StartupEventArgs e)
    {
      base.OnStartup(e);

      host.StartAsync();

      MainWindow = Ioc.Default.GetRequiredService<MainWindow>();
      MainWindow.Show();
    }

    protected override void OnExit(ExitEventArgs e)
    {
      host.StopAsync();

      base.OnExit(e);
    }
  }
}
