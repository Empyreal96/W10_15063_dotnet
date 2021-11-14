// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IDeviceWatcherTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DeviceWatcherTrigger))]
  [Guid(2757853149, 34163, 16992, 190, 252, 91, 236, 137, 203, 105, 61)]
  internal interface IDeviceWatcherTrigger : IBackgroundTrigger
  {
  }
}
