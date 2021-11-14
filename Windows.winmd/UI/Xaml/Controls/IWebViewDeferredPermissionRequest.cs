// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewDeferredPermissionRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(2749154401, 29520, 19770, 143, 185, 64, 238, 236, 39, 70, 194)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebViewDeferredPermissionRequest))]
  internal interface IWebViewDeferredPermissionRequest
  {
    Uri Uri { get; }

    WebViewPermissionType PermissionType { get; }

    uint Id { get; }

    void Allow();

    void Deny();
  }
}
