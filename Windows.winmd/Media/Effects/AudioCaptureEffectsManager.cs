// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.AudioCaptureEffectsManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  public sealed class AudioCaptureEffectsManager : IAudioCaptureEffectsManager
  {
    public extern event TypedEventHandler<AudioCaptureEffectsManager, object> AudioCaptureEffectsChanged;

    [MethodImpl]
    public extern IVectorView<AudioEffect> GetAudioCaptureEffects();
  }
}
