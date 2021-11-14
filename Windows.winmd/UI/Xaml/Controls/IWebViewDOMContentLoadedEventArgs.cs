// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewDOMContentLoadedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebViewDOMContentLoadedEventArgs))]
  [WebHostHidden]
  [Guid(3296639509, 56427, 19254, 157, 128, 130, 251, 136, 23, 185, 136)]
  internal interface IWebViewDOMContentLoadedEventArgs
  {
    Uri Uri { get; }
  }
}
