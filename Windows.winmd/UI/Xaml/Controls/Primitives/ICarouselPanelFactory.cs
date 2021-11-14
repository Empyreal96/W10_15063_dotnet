// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ICarouselPanelFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [Guid(3239089156, 39649, 17422, 160, 221, 187, 182, 226, 41, 60, 190)]
  [ExclusiveTo(typeof (CarouselPanel))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICarouselPanelFactory
  {
    CarouselPanel CreateInstance(object outer, out object inner);
  }
}
