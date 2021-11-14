// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IAudioCaptureEffectsManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  [Guid(2407907953, 909, 17299, 130, 152, 84, 1, 16, 96, 142, 239)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AudioCaptureEffectsManager))]
  internal interface IAudioCaptureEffectsManager
  {
    event TypedEventHandler<AudioCaptureEffectsManager, object> AudioCaptureEffectsChanged;

    IVectorView<AudioEffect> GetAudioCaptureEffects();
  }
}
