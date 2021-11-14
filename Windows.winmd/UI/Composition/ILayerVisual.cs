// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ILayerVisual
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (LayerVisual))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2944678277, 1092, 18567, 142, 131, 180, 11, 37, 63, 130, 44)]
  internal interface ILayerVisual
  {
    CompositionEffectBrush Effect { get; set; }
  }
}
