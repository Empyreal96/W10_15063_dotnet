// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.IShape2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Xaml.Shapes
{
  [ExclusiveTo(typeof (Shape))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2535755194, 18930, 18852, 165, 221, 22, 77, 248, 36, 219, 20)]
  [WebHostHidden]
  internal interface IShape2
  {
    CompositionBrush GetAlphaMask();
  }
}
