// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewUnsupportedUriSchemeIdentifiedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3117015463, 25103, 18581, 147, 93, 16, 251, 172, 111, 210, 158)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebViewUnsupportedUriSchemeIdentifiedEventArgs))]
  [WebHostHidden]
  internal interface IWebViewUnsupportedUriSchemeIdentifiedEventArgs
  {
    Uri Uri { get; }

    bool Handled { get; set; }
  }
}
