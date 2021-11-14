// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.IWebAuthenticationCoreManagerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.System;

namespace Windows.Security.Authentication.Web.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4119074890, 35671, 18464, 182, 164, 112, 165, 182, 252, 244, 74)]
  [ExclusiveTo(typeof (WebAuthenticationCoreManager))]
  internal interface IWebAuthenticationCoreManagerStatics2 : IWebAuthenticationCoreManagerStatics
  {
    [RemoteAsync]
    [Overload("FindAccountProviderWithAuthorityForUserAsync")]
    IAsyncOperation<WebAccountProvider> FindAccountProviderAsync(
      string webAccountProviderId,
      string authority,
      User user);
  }
}
