// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.AudioEffectType
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AudioEffectType
  {
    Other,
    AcousticEchoCancellation,
    NoiseSuppression,
    AutomaticGainControl,
    BeamForming,
    ConstantToneRemoval,
    Equalizer,
    LoudnessEqualizer,
    BassBoost,
    VirtualSurround,
    VirtualHeadphones,
    SpeakerFill,
    RoomCorrection,
    BassManagement,
    EnvironmentalEffects,
    SpeakerProtection,
    SpeakerCompensation,
    DynamicRangeCompression,
  }
}
