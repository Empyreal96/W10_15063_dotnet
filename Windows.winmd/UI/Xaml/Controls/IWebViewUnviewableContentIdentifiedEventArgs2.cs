// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewUnviewableContentIdentifiedEventArgs2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (WebViewUnviewableContentIdentifiedEventArgs))]
  [Guid(2596147540, 14064, 17000, 141, 136, 18, 30, 237, 244, 94, 106)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IWebViewUnviewableContentIdentifiedEventArgs2
  {
    string MediaType { get; }
  }
}
