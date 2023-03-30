namespace ListViewSample.Services
{
  internal interface ISettingService
  {
    string SettingFile { get; }
    void Load(string path);
    void Save(string path);
  }
}