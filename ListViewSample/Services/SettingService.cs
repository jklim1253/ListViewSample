using ListViewSample.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ListViewSample.Services
{
  internal class SettingService : ISettingService
  {
    private readonly JsonSerializerOptions options = new JsonSerializerOptions()
    {
      WriteIndented = true
    };

    private Setting CurrentSetting = null!;

    public string SettingFile { get; } = null!;

    public SettingService()
    {
      SettingFile = AppDomain.CurrentDomain.BaseDirectory +
                    Path.DirectorySeparatorChar +
                    "SampleSetting.json";
    }

    public void Load(string path)
    {
      if (!File.Exists(path))
      {
        createSetting(path);
        return;
      }

      using (var stream = new StreamReader(path))
      {
        var json = stream.ReadToEnd();

        if (JsonSerializer.Deserialize<Setting>(json) is Setting loaded)
        {
          CurrentSetting = loaded;
        }
      }
    }

    public void Save(string path)
    {

    }

    private void createSetting(string path)
    {
      // new Setting object will be written to path.
      CurrentSetting = new Setting();
      var json = JsonSerializer.Serialize(CurrentSetting, options);

      using (var stream = new StreamWriter(path))
      {
        stream.Write(json);
      }
    }

  }
}
