// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IAudioRenderEffectsManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1305053542, 34641, 17074, 191, 203, 57, 202, 120, 100, 189, 71)]
  [ExclusiveTo(typeof (AudioRenderEffectsManager))]
  internal interface IAudioRenderEffectsManager
  {
    event TypedEventHandler<AudioRenderEffectsManager, object> AudioRenderEffectsChanged;

    IVectorView<AudioEffect> GetAudioRenderEffects();
  }
}
