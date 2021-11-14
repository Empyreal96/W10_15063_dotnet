// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.BingMapsTask
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Device.Location;

namespace Microsoft.Phone.Tasks
{
  public sealed class BingMapsTask
  {
    private MapsTask theRealOne;

    public BingMapsTask() => this.theRealOne = new MapsTask();

    public GeoCoordinate Center
    {
      get => this.theRealOne.Center;
      set => this.theRealOne.Center = value;
    }

    public string SearchTerm
    {
      get => this.theRealOne.SearchTerm;
      set => this.theRealOne.SearchTerm = value;
    }

    public double ZoomLevel
    {
      get => this.theRealOne.ZoomLevel;
      set => this.theRealOne.ZoomLevel = value;
    }

    public void Show() => this.theRealOne.Show();
  }
}
