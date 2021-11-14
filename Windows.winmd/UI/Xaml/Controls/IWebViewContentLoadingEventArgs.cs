// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewContentLoadingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (WebViewContentLoadingEventArgs))]
  [Guid(1848213691, 39096, 16702, 129, 41, 151, 28, 111, 126, 76, 138)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebViewContentLoadingEventArgs
  {
    Uri Uri { get; }
  }
}
