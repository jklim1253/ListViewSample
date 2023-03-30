﻿using ListViewSample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ListViewSample.ViewModels
{
  internal class HomeViewModel : ViewModelBase
  {
    public HomeViewModel(ISettingService setting) : base(setting)
    {

    }

    protected override void OnLoad()
    {
      base.OnLoad();
    }

    protected override void OnUnload()
    {
      base.OnUnload();
    }
  }
}
