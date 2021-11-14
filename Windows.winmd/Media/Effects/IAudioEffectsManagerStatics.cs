// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IAudioEffectsManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;
using Windows.Media.Render;

namespace Windows.Media.Effects
{
  [ExclusiveTo(typeof (AudioEffectsManager))]
  [Guid(1715497988, 34554, 18380, 163, 21, 244, 137, 216, 195, 254, 16)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAudioEffectsManagerStatics
  {
    [Overload("CreateAudioRenderEffectsManager")]
    AudioRenderEffectsManager CreateAudioRenderEffectsManager(
      string deviceId,
      AudioRenderCategory category);

    [Overload("CreateAudioRenderEffectsManagerWithMode")]
    AudioRenderEffectsManager CreateAudioRenderEffectsManager(
      string deviceId,
      AudioRenderCategory category,
      AudioProcessing mode);

    [Overload("CreateAudioCaptureEffectsManager")]
    AudioCaptureEffectsManager CreateAudioCaptureEffectsManager(
      string deviceId,
      MediaCategory category);

    [Overload("CreateAudioCaptureEffectsManagerWithMode")]
    AudioCaptureEffectsManager CreateAudioCaptureEffectsManager(
      string deviceId,
      MediaCategory category,
      AudioProcessing mode);
  }
}
