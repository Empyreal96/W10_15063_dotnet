// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.AudioDeviceModuleNotificationEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Devices
{
  [DualApiPartition(version = 167772163)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AudioDeviceModuleNotificationEventArgs : 
    IAudioDeviceModuleNotificationEventArgs
  {
    public extern AudioDeviceModule Module { [MethodImpl] get; }

    public extern IBuffer NotificationData { [MethodImpl] get; }
  }
}
