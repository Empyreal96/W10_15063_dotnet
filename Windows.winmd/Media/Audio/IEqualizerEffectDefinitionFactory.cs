// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IEqualizerEffectDefinitionFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [Guid(3532091332, 54288, 20149, 158, 105, 201, 170, 18, 119, 234, 240)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EqualizerEffectDefinition))]
  internal interface IEqualizerEffectDefinitionFactory
  {
    EqualizerEffectDefinition Create(AudioGraph audioGraph);
  }
}
