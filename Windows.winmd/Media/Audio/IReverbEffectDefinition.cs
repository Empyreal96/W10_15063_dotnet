// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IReverbEffectDefinition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Effects;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1174841993, 62819, 19722, 143, 110, 240, 205, 223, 243, 93, 132)]
  [ExclusiveTo(typeof (ReverbEffectDefinition))]
  internal interface IReverbEffectDefinition : IAudioEffectDefinition
  {
    double WetDryMix { set; get; }

    uint ReflectionsDelay { set; get; }

    byte ReverbDelay { set; get; }

    byte RearDelay { set; get; }

    byte PositionLeft { set; get; }

    byte PositionRight { set; get; }

    byte PositionMatrixLeft { set; get; }

    byte PositionMatrixRight { set; get; }

    byte EarlyDiffusion { set; get; }

    byte LateDiffusion { set; get; }

    byte LowEQGain { set; get; }

    byte LowEQCutoff { set; get; }

    byte HighEQGain { set; get; }

    byte HighEQCutoff { set; get; }

    double RoomFilterFreq { set; get; }

    double RoomFilterMain { set; get; }

    double RoomFilterHF { set; get; }

    double ReflectionsGain { set; get; }

    double ReverbGain { set; get; }

    double DecayTime { set; get; }

    double Density { set; get; }

    double RoomSize { set; get; }

    bool DisableLateField { set; get; }
  }
}
