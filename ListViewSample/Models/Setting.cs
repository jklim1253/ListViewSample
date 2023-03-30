using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewSample.Models
{
  internal class Setting
  {
    public AppSetting App { get; set; } = AppSetting.Default;
    public HomeSetting Home { get; set; } = HomeSetting.Default;
  }
}
