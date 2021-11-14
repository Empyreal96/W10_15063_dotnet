// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceWatcherTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ExclusiveTo(typeof (DeviceWatcherTriggerDetails))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(947945753, 19639, 20055, 165, 109, 119, 109, 7, 203, 254, 249)]
  internal interface IDeviceWatcherTriggerDetails
  {
    IVectorView<DeviceWatcherEvent> DeviceWatcherEvents { get; }
  }
}
