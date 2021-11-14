// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.ILimiterEffectDefinitionFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LimiterEffectDefinition))]
  [Guid(3971671793, 25087, 17903, 184, 245, 72, 101, 154, 87, 199, 45)]
  internal interface ILimiterEffectDefinitionFactory
  {
    LimiterEffectDefinition Create(AudioGraph audioGraph);
  }
}
