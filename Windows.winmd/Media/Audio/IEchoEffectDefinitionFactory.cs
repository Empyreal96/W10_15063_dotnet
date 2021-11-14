// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IEchoEffectDefinitionFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ExclusiveTo(typeof (EchoEffectDefinition))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(223224407, 43762, 20102, 165, 76, 251, 121, 219, 143, 108, 18)]
  internal interface IEchoEffectDefinitionFactory
  {
    EchoEffectDefinition Create(AudioGraph audioGraph);
  }
}
