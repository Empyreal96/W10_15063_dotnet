// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.IWebTokenRequest
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
  [ExclusiveTo(typeof (WebTokenRequest))]
  [Guid(3078311272, 44491, 18035, 179, 100, 12, 247, 179, 92, 175, 151)]
  internal interface IWebTokenRequest
  {
    WebAccountProvider WebAccountProvider { get; }

    string Scope { get; }

    string ClientId { get; }

    WebTokenRequestPromptType PromptType { get; }

    IMap<string, string> Properties { get; }
  }
}
