// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewNavigationFailedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2936627354, 4764, 16752, 158, 156, 226, 205, 240, 37, 220, 164)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebViewNavigationFailedEventArgs))]
  [WebHostHidden]
  internal interface IWebViewNavigationFailedEventArgs
  {
    Uri Uri { get; }

    WebErrorStatus WebErrorStatus { get; }
  }
}
