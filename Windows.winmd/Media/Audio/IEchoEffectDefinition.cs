// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IEchoEffectDefinition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Effects;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(239943594, 14008, 19601, 185, 218, 17, 244, 74, 138, 102, 16)]
  [ExclusiveTo(typeof (EchoEffectDefinition))]
  internal interface IEchoEffectDefinition : IAudioEffectDefinition
  {
    double WetDryMix { set; get; }

    double Feedback { set; get; }

    double Delay { set; get; }
  }
}
