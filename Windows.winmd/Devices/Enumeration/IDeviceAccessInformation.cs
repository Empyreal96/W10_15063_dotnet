// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceAccessInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ExclusiveTo(typeof (DeviceAccessInformation))]
  [Guid(195730035, 28133, 18709, 141, 221, 154, 5, 84, 166, 245, 69)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDeviceAccessInformation
  {
    event TypedEventHandler<DeviceAccessInformation, DeviceAccessChangedEventArgs> AccessChanged;

    DeviceAccessStatus CurrentStatus { get; }
  }
}
