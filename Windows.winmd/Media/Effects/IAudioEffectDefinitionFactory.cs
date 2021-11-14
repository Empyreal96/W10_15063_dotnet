// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IAudioEffectDefinitionFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  [ExclusiveTo(typeof (AudioEffectDefinition))]
  [Guid(2384307782, 59141, 17901, 138, 43, 252, 78, 79, 64, 90, 151)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAudioEffectDefinitionFactory
  {
    AudioEffectDefinition Create(string activatableClassId);

    AudioEffectDefinition CreateWithProperties(
      string activatableClassId,
      IPropertySet props);
  }
}
