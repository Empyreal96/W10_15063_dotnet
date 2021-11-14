// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IVideoEffectDefinitionFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  [ExclusiveTo(typeof (VideoEffectDefinition))]
  [Guid(2168691534, 28211, 17039, 157, 33, 181, 170, 254, 247, 97, 124)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVideoEffectDefinitionFactory
  {
    VideoEffectDefinition Create(string activatableClassId);

    VideoEffectDefinition CreateWithProperties(
      string activatableClassId,
      IPropertySet props);
  }
}
