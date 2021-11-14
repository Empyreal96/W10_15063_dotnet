// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionMaskBrush
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Guid(1378676894, 48747, 20289, 190, 73, 249, 34, 109, 71, 27, 74)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (CompositionMaskBrush))]
  [WebHostHidden]
  internal interface ICompositionMaskBrush
  {
    CompositionBrush Mask { get; set; }

    CompositionBrush Source { get; set; }
  }
}
