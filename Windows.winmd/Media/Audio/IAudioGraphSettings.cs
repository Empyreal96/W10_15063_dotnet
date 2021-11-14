// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioGraphSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;
using Windows.Media.Render;

namespace Windows.Media.Audio
{
  [ExclusiveTo(typeof (AudioGraphSettings))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(492397695, 59134, 17960, 132, 248, 157, 139, 219, 162, 87, 133)]
  internal interface IAudioGraphSettings
  {
    AudioEncodingProperties EncodingProperties { get; set; }

    DeviceInformation PrimaryRenderDevice { get; set; }

    QuantumSizeSelectionMode QuantumSizeSelectionMode { get; set; }

    int DesiredSamplesPerQuantum { get; set; }

    AudioRenderCategory AudioRenderCategory { get; set; }

    AudioProcessing DesiredRenderDeviceAudioProcessing { get; set; }
  }
}
