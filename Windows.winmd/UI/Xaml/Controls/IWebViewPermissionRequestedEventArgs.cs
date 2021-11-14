// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewPermissionRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebViewPermissionRequestedEventArgs))]
  [Guid(3672035280, 28190, 18239, 176, 190, 176, 36, 4, 214, 168, 109)]
  internal interface IWebViewPermissionRequestedEventArgs
  {
    WebViewPermissionRequest PermissionRequest { get; }
  }
}
