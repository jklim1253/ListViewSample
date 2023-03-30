using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ListViewSample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewSample.ViewModels
{
  internal class ViewModelBase : ObservableObject
  {
    #region Fields

    protected readonly ISettingService setting;

    #endregion

    #region Properties

    private int viewCounter = 0;
    public int ViewCounter
		{
			get => viewCounter;
			set => SetProperty(ref viewCounter, value);
		}

    #endregion

    #region Commands

    public IRelayCommand LoadCommand { get; }
		public IRelayCommand UnloadCommand { get; }

    #endregion

		protected ViewModelBase(ISettingService setting)
		{
      this.setting = setting;

			LoadCommand = new RelayCommand(OnLoad);
			UnloadCommand = new RelayCommand(OnUnload);
    }

    protected virtual void OnLoad()
    {
			++ViewCounter;
    }

    protected virtual void OnUnload()
    {
    }
  }
}
