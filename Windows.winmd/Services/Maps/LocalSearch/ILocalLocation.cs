// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.LocalSearch.ILocalLocation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.LocalSearch
{
  [Guid(3138382251, 17666, 20268, 148, 169, 13, 96, 222, 14, 33, 99)]
  [ExclusiveTo(typeof (LocalLocation))]
  [ContractVersion(typeof (LocalSearchContract), 65536)]
  [WebHostHidden]
  internal interface ILocalLocation
  {
    MapAddress Address { get; }

    string Identifier { get; }

    string Description { get; }

    string DisplayName { get; }

    Geopoint Point { get; }

    string PhoneNumber { get; }

    string DataAttribution { get; }
  }
}
