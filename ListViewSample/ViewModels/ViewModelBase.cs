using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewSample.ViewModels
{
  internal class ViewModelBase : ObservableObject
  {
		private int viewCounter = 0;
		public int ViewCounter
		{
			get => viewCounter;
			set => SetProperty(ref viewCounter, value);
		}

		public IRelayCommand LoadCommand { get; }
		public IRelayCommand UnloadCommand { get; }

		protected ViewModelBase()
		{
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
