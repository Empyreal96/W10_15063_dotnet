// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IVideoCompositorDefinitionFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  [Guid(1130822928, 26808, 19794, 137, 182, 2, 169, 104, 204, 168, 153)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VideoCompositorDefinition))]
  internal interface IVideoCompositorDefinitionFactory
  {
    VideoCompositorDefinition Create(string activatableClassId);

    VideoCompositorDefinition CreateWithProperties(
      string activatableClassId,
      IPropertySet props);
  }
}
