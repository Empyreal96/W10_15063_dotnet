// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioNodeEmitterNaturalDecayModelProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1217612751, 53036, 20220, 147, 49, 117, 189, 34, 223, 31, 12)]
  [ExclusiveTo(typeof (AudioNodeEmitterNaturalDecayModelProperties))]
  internal interface IAudioNodeEmitterNaturalDecayModelProperties
  {
    double UnityGainDistance { get; }

    double CutoffDistance { get; }
  }
}
