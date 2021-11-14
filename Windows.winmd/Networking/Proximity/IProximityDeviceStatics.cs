// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.IProximityDeviceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Proximity
{
  [Guid(2437652509, 63201, 18372, 161, 76, 20, 138, 25, 3, 208, 198)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ProximityDevice))]
  internal interface IProximityDeviceStatics
  {
    string GetDeviceSelector();

    ProximityDevice GetDefault();

    ProximityDevice FromId(string deviceId);
  }
}
