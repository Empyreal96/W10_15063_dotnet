// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioGraphSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;
using Windows.Media.Render;

namespace Windows.Media.Audio
{
  [Activatable(typeof (IAudioGraphSettingsFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class AudioGraphSettings : IAudioGraphSettings
  {
    [MethodImpl]
    public extern AudioGraphSettings(AudioRenderCategory audioRenderCategory);

    public extern AudioEncodingProperties EncodingProperties { [MethodImpl] get; [MethodImpl] set; }

    public extern DeviceInformation PrimaryRenderDevice { [MethodImpl] get; [MethodImpl] set; }

    public extern QuantumSizeSelectionMode QuantumSizeSelectionMode { [MethodImpl] get; [MethodImpl] set; }

    public extern int DesiredSamplesPerQuantum { [MethodImpl] get; [MethodImpl] set; }

    public extern AudioRenderCategory AudioRenderCategory { [MethodImpl] get; [MethodImpl] set; }

    public extern AudioProcessing DesiredRenderDeviceAudioProcessing { [MethodImpl] get; [MethodImpl] set; }
  }
}
