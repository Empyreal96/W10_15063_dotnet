// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceWatcher2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4278732142, 60692, 18921, 154, 105, 129, 23, 197, 74, 233, 113)]
  [ExclusiveTo(typeof (DeviceWatcher))]
  internal interface IDeviceWatcher2
  {
    DeviceWatcherTrigger GetBackgroundTrigger(
      IIterable<DeviceWatcherEventKind> requestedEventKinds);
  }
}
