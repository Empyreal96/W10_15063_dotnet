// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IVisualTreeHelperStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (VisualTreeHelper))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(129814902, 34463, 17575, 135, 151, 33, 3, 164, 195, 228, 122)]
  internal interface IVisualTreeHelperStatics2
  {
    IVectorView<Popup> GetOpenPopups(Window window);
  }
}
