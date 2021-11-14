// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IAudioEffect
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  [ExclusiveTo(typeof (AudioEffect))]
  [Guid(883620433, 37383, 16469, 190, 147, 110, 87, 52, 168, 106, 228)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAudioEffect
  {
    AudioEffectType AudioEffectType { get; }
  }
}
