// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IAudioDeviceController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [Guid(3990135688, 31175, 20348, 144, 232, 239, 147, 75, 33, 88, 10)]
  [ExclusiveTo(typeof (AudioDeviceController))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAudioDeviceController : IMediaDeviceController
  {
    bool Muted { set; get; }

    float VolumePercent { set; get; }
  }
}
