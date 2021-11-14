// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.AudioRenderEffectsManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Effects
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  public sealed class AudioRenderEffectsManager : 
    IAudioRenderEffectsManager,
    IAudioRenderEffectsManager2
  {
    public extern event TypedEventHandler<AudioRenderEffectsManager, object> AudioRenderEffectsChanged;

    [MethodImpl]
    public extern IVectorView<AudioEffect> GetAudioRenderEffects();

    public extern IRandomAccessStreamWithContentType EffectsProviderThumbnail { [Deprecated("Not supported starting in windows 10", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern string EffectsProviderSettingsLabel { [Deprecated("Not supported starting in windows 10", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    [Deprecated("Not supported starting in windows 10", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void ShowSettingsUI();
  }
}
