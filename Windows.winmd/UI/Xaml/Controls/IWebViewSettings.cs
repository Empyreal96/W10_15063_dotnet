// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(491826509, 44022, 18309, 141, 243, 253, 235, 193, 39, 3, 1)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebViewSettings))]
  internal interface IWebViewSettings
  {
    bool IsJavaScriptEnabled { get; set; }

    bool IsIndexedDBEnabled { get; set; }
  }
}
