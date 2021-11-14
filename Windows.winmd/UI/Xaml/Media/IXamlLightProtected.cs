// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IXamlLightProtected
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [Guid(1590632971, 4690, 17360, 151, 41, 110, 166, 146, 4, 104, 56)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (XamlLight))]
  internal interface IXamlLightProtected
  {
    CompositionLight CompositionLight { get; set; }
  }
}
