// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.IWebTokenResponse
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Security.Authentication.Web.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1739048394, 33782, 17606, 163, 177, 14, 182, 158, 65, 250, 138)]
  [ExclusiveTo(typeof (WebTokenResponse))]
  internal interface IWebTokenResponse
  {
    string Token { get; }

    WebProviderError ProviderError { get; }

    WebAccount WebAccount { get; }

    IMap<string, string> Properties { get; }
  }
}
