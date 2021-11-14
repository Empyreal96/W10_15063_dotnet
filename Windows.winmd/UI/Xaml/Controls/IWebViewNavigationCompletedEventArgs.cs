// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewNavigationCompletedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(300347915, 60327, 17600, 136, 155, 237, 235, 106, 6, 77, 221)]
  [ExclusiveTo(typeof (WebViewNavigationCompletedEventArgs))]
  internal interface IWebViewNavigationCompletedEventArgs
  {
    Uri Uri { get; }

    bool IsSuccess { get; }

    WebErrorStatus WebErrorStatus { get; }
  }
}
