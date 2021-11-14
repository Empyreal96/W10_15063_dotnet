// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (WebView))]
  [Guid(841975680, 59410, 18027, 158, 80, 142, 159, 236, 36, 1, 138)]
  internal interface IWebViewStatics2
  {
    DependencyProperty CanGoBackProperty { get; }

    DependencyProperty CanGoForwardProperty { get; }

    DependencyProperty DocumentTitleProperty { get; }

    DependencyProperty DefaultBackgroundColorProperty { get; }
  }
}
