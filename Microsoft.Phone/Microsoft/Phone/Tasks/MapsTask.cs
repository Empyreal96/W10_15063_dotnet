// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.MapsTask
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using System.Device.Location;
using System.Globalization;

namespace Microsoft.Phone.Tasks
{
  public sealed class MapsTask
  {
    private const double InvalidZoomLevel = -1.0;
    private double _zoomLevel;

    public MapsTask() => this._zoomLevel = -1.0;

    public GeoCoordinate Center { get; set; }

    public string SearchTerm { get; set; }

    public double ZoomLevel
    {
      get => this._zoomLevel;
      set => this._zoomLevel = value > 0.0 ? value : throw new ArgumentOutOfRangeException(nameof (ZoomLevel), "ZoomLevel must be larger than zero");
    }

    public void Show()
    {
      if (!ChooserHelper.NavigationInProgressGuard((Action) (() => this.Show())))
        return;
      ChooserHelper.LaunchSession(this.BuildUri(), new ParameterPropertyBag());
    }

    internal Uri BuildUri() => new Uri("bingmaps:?" + this.GetParams(), UriKind.Absolute);

    private string GetParams()
    {
      string str = (string) null;
      if (this.Center == (GeoCoordinate) null && (this.SearchTerm == null || string.IsNullOrEmpty(this.SearchTerm.Trim())))
        throw new InvalidOperationException("SearchTerm and Center cannot both be empty.");
      if (!string.IsNullOrWhiteSpace(this.SearchTerm))
        str = str + "q=" + this.SearchTerm;
      if (this.Center != (GeoCoordinate) null)
      {
        if (!string.IsNullOrEmpty(str))
          str += "&";
        str = str + "cp=" + this.Center.Latitude.ToString((IFormatProvider) CultureInfo.InvariantCulture) + "~" + this.Center.Longitude.ToString((IFormatProvider) CultureInfo.InvariantCulture);
      }
      if (this._zoomLevel > 0.0)
      {
        if (!string.IsNullOrEmpty(str))
          str += "&";
        str = str + "lvl=" + this._zoomLevel.ToString((IFormatProvider) CultureInfo.InvariantCulture);
      }
      return str;
    }
  }
}
