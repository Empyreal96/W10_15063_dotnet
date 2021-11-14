// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.AudioEffectsManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;
using Windows.Media.Render;

namespace Windows.Media.Effects
{
  [Threading(ThreadingModel.MTA)]
  [Static(typeof (IAudioEffectsManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class AudioEffectsManager
  {
    [Overload("CreateAudioRenderEffectsManager")]
    [MethodImpl]
    public static extern AudioRenderEffectsManager CreateAudioRenderEffectsManager(
      string deviceId,
      AudioRenderCategory category);

    [Overload("CreateAudioRenderEffectsManagerWithMode")]
    [MethodImpl]
    public static extern AudioRenderEffectsManager CreateAudioRenderEffectsManager(
      string deviceId,
      AudioRenderCategory category,
      AudioProcessing mode);

    [Overload("CreateAudioCaptureEffectsManager")]
    [MethodImpl]
    public static extern AudioCaptureEffectsManager CreateAudioCaptureEffectsManager(
      string deviceId,
      MediaCategory category);

    [Overload("CreateAudioCaptureEffectsManagerWithMode")]
    [MethodImpl]
    public static extern AudioCaptureEffectsManager CreateAudioCaptureEffectsManager(
      string deviceId,
      MediaCategory category,
      AudioProcessing mode);
  }
}
