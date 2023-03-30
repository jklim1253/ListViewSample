namespace ListViewSample.Models
{
  internal class HomeSetting
  {
    public int Version { get; set; } = 0;
    public string VersionName { get; set; } = string.Empty;
    public double HomeLeftSideWidth { get; set; } = 0;

    public static readonly HomeSetting Default = new HomeSetting()
    {
      Version = 10000,
      VersionName = "1.0.0",
      HomeLeftSideWidth = 150
    };
  }
}