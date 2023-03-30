namespace ListViewSample.Models
{
  internal class AppSetting
  {
    public string Name { get; set; } = string.Empty;
    public int Version { get; set; } = 0;
    public string VersionName { get; set; } = string.Empty;

    public static readonly AppSetting Default = new AppSetting()
    {
      Name = "LiveViewSample",
      Version = 10000,
      VersionName = "1.0.0"
    };
  }
}