// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewNewWindowRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (WebViewNewWindowRequestedEventArgs))]
  [WebHostHidden]
  [Guid(1192208408, 26722, 17625, 179, 209, 192, 105, 99, 115, 222, 53)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebViewNewWindowRequestedEventArgs
  {
    Uri Uri { get; }

    Uri Referrer { get; }

    bool Handled { get; set; }
  }
}
