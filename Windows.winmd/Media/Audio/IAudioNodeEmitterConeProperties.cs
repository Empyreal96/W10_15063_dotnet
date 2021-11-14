// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioNodeEmitterConeProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AudioNodeEmitterConeProperties))]
  [Guid(3919260910, 714, 17269, 147, 38, 12, 106, 228, 188, 223, 181)]
  internal interface IAudioNodeEmitterConeProperties
  {
    double InnerAngle { get; }

    double OuterAngle { get; }

    double OuterAngleGain { get; }
  }
}
