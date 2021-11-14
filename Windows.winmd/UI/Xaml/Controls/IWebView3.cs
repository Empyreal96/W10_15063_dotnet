// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebView3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (WebView))]
  [Guid(3298261147, 46233, 19817, 181, 194, 174, 157, 93, 109, 89, 78)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IWebView3
  {
    bool ContainsFullScreenElement { get; }

    event TypedEventHandler<WebView, object> ContainsFullScreenElementChanged;
  }
}
