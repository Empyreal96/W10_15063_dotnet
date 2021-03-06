// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.GeoCoordinateCollection
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.Collections.ObjectModel;
using System.Device.Location;

namespace Microsoft.Phone.Maps.Controls
{
  public sealed class GeoCoordinateCollection : ObservableCollection<GeoCoordinate>
  {
    protected virtual void InsertItem(int index, GeoCoordinate item)
    {
      if (item == (GeoCoordinate) null)
        throw new ArgumentNullException(nameof (item));
      base.InsertItem(index, item);
    }

    protected virtual void SetItem(int index, GeoCoordinate item)
    {
      if (item == (GeoCoordinate) null)
        throw new ArgumentNullException(nameof (item));
      base.SetItem(index, item);
    }
  }
}
