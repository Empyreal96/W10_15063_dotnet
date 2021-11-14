// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewUnviewableContentIdentifiedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(935073505, 24674, 18040, 178, 11, 108, 54, 172, 156, 89, 172)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (WebViewUnviewableContentIdentifiedEventArgs))]
  internal interface IWebViewUnviewableContentIdentifiedEventArgs
  {
    Uri Uri { get; }

    Uri Referrer { get; }
  }
}
