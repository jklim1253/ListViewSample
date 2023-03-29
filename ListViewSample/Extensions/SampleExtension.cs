using ListViewSample.ViewModels;
using ListViewSample.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewSample.Extensions
{
  internal static class SampleExtension
  {
    public static IHostBuilder SampleConfigure(this IHostBuilder hostBuilder)
    {
      return hostBuilder.ConfigureServices(services =>
      {
        services.AddSingleton<MainViewModel>();
        services.AddSingleton<LoadingViewModel>();
        services.AddSingleton<HomeViewModel>();

        services.AddTransient<MainWindow>();
        services.AddTransient<LoadingView>();
        services.AddTransient<HomeView>();
      });
    }
  }
}
