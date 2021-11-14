// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IAudioDeviceModuleNotificationEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Devices
{
  [ExclusiveTo(typeof (AudioDeviceModuleNotificationEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3823357103, 8780, 18622, 149, 107, 154, 19, 19, 78, 150, 232)]
  internal interface IAudioDeviceModuleNotificationEventArgs
  {
    AudioDeviceModule Module { get; }

    IBuffer NotificationData { get; }
  }
}
