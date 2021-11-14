// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IEqualizerEffectDefinition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Effects;

namespace Windows.Media.Audio
{
  [ExclusiveTo(typeof (EqualizerEffectDefinition))]
  [Guid(37711647, 33790, 17562, 168, 34, 198, 150, 68, 45, 22, 176)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEqualizerEffectDefinition : IAudioEffectDefinition
  {
    IVectorView<EqualizerBand> Bands { get; }
  }
}
