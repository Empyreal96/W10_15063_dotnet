// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceInformationUpdate
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ExclusiveTo(typeof (DeviceInformationUpdate))]
  [Guid(2402374405, 55666, 17591, 163, 126, 158, 130, 44, 120, 33, 59)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDeviceInformationUpdate
  {
    string Id { get; }

    IMapView<string, object> Properties { [return: HasVariant] get; }
  }
}
