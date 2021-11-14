// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewPermissionRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebViewPermissionRequest))]
  [Guid(397894450, 26308, 16689, 153, 158, 223, 125, 226, 10, 140, 156)]
  internal interface IWebViewPermissionRequest
  {
    Uri Uri { get; }

    WebViewPermissionType PermissionType { get; }

    uint Id { get; }

    WebViewPermissionState State { get; }

    void Defer();

    void Allow();

    void Deny();
  }
}
