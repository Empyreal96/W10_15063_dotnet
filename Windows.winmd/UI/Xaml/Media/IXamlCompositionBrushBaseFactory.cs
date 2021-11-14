// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IXamlCompositionBrushBaseFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (XamlCompositionBrushBase))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  [Guid(961480739, 9297, 20184, 189, 36, 72, 129, 73, 179, 66, 141)]
  internal interface IXamlCompositionBrushBaseFactory
  {
    XamlCompositionBrushBase CreateInstance(object outer, out object inner);
  }
}
