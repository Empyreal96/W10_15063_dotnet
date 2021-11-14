// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.ICivicAddress
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [Guid(2824239642, 25844, 19784, 188, 234, 246, 176, 8, 236, 163, 76)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CivicAddress))]
  internal interface ICivicAddress
  {
    string Country { get; }

    string State { get; }

    string City { get; }

    string PostalCode { get; }

    DateTime Timestamp { get; }
  }
}
