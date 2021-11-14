// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IXamlCompositionBrushBaseProtected
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Xaml.Media
{
  [Guid(353629144, 1111, 19996, 173, 119, 17, 193, 217, 135, 151, 67)]
  [WebHostHidden]
  [ExclusiveTo(typeof (XamlCompositionBrushBase))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IXamlCompositionBrushBaseProtected
  {
    CompositionBrush CompositionBrush { get; set; }
  }
}
