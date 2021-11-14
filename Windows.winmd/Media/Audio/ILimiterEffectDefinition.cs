// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.ILimiterEffectDefinition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Effects;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LimiterEffectDefinition))]
  [Guid(1802853657, 9731, 18362, 189, 235, 57, 5, 94, 52, 134, 220)]
  internal interface ILimiterEffectDefinition : IAudioEffectDefinition
  {
    uint Release { set; get; }

    uint Loudness { set; get; }
  }
}
