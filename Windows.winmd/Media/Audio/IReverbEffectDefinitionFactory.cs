// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IReverbEffectDefinitionFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ExclusiveTo(typeof (ReverbEffectDefinition))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2815806462, 4107, 20464, 157, 166, 220, 78, 5, 167, 89, 240)]
  internal interface IReverbEffectDefinitionFactory
  {
    ReverbEffectDefinition Create(AudioGraph audioGraph);
  }
}
