// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewNavigationStartingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2496366184, 33639, 17365, 145, 187, 150, 235, 163, 126, 199, 132)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebViewNavigationStartingEventArgs))]
  internal interface IWebViewNavigationStartingEventArgs
  {
    Uri Uri { get; }

    bool Cancel { get; set; }
  }
}
