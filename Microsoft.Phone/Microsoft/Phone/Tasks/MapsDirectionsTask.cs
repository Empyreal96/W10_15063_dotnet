// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.MapsDirectionsTask
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using System.Device.Location;
using System.Globalization;

namespace Microsoft.Phone.Tasks
{
  public sealed class MapsDirectionsTask
  {
    public LabeledMapLocation Start { get; set; }

    public LabeledMapLocation End { get; set; }

    public void Show()
    {
      if (!ChooserHelper.NavigationInProgressGuard((Action) (() => this.Show())))
        return;
      ChooserHelper.LaunchSession(this.BuildUri(), new ParameterPropertyBag());
    }

    private string GetParams()
    {
      if (!this.isValidLabeledMapLocation(this.Start) && !this.isValidLabeledMapLocation(this.End))
        throw new InvalidOperationException("Start and End cannot both be invalid.");
      string str1 = "rtp=";
      double num;
      if (this.Start != null)
      {
        if (this.Start.Location != (GeoCoordinate) null)
        {
          string[] strArray = new string[5]
          {
            str1,
            "pos.",
            null,
            null,
            null
          };
          num = this.Start.Location.Latitude;
          strArray[2] = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);
          strArray[3] = "_";
          num = this.Start.Location.Longitude;
          strArray[4] = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);
          str1 = string.Concat(strArray);
          if (!string.IsNullOrWhiteSpace(this.Start.Label))
            str1 = str1 + "_" + this.Start.Label;
        }
        else if (!string.IsNullOrWhiteSpace(this.Start.Label))
          str1 = str1 + "adr." + this.Start.Label;
      }
      string str2 = str1 + "~";
      if (this.End != null)
      {
        if (this.End.Location != (GeoCoordinate) null)
        {
          string[] strArray = new string[5]
          {
            str2,
            "pos.",
            null,
            null,
            null
          };
          num = this.End.Location.Latitude;
          strArray[2] = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);
          strArray[3] = "_";
          num = this.End.Location.Longitude;
          strArray[4] = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);
          str2 = string.Concat(strArray);
          if (!string.IsNullOrWhiteSpace(this.End.Label))
            str2 = str2 + "_" + this.End.Label;
        }
        else if (!string.IsNullOrWhiteSpace(this.End.Label))
          str2 = str2 + "adr." + this.End.Label;
      }
      return str2;
    }

    internal Uri BuildUri() => new Uri("bingmaps:?" + this.GetParams(), UriKind.Absolute);

    private bool isValidLabeledMapLocation(LabeledMapLocation location) => location != null && (location.Label != null && !string.IsNullOrEmpty(location.Label.Trim()) || !(location.Location == (GeoCoordinate) null));
  }
}
