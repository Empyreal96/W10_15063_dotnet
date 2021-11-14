// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.WebTokenResponse
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Security.Authentication.Web.Core
{
  [Activatable(typeof (IWebTokenResponseFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class WebTokenResponse : IWebTokenResponse
  {
    [MethodImpl]
    public extern WebTokenResponse(string token);

    [MethodImpl]
    public extern WebTokenResponse(string token, WebAccount webAccount);

    [MethodImpl]
    public extern WebTokenResponse(string token, WebAccount webAccount, WebProviderError error);

    [MethodImpl]
    public extern WebTokenResponse();

    public extern string Token { [MethodImpl] get; }

    public extern WebProviderError ProviderError { [MethodImpl] get; }

    public extern WebAccount WebAccount { [MethodImpl] get; }

    public extern IMap<string, string> Properties { [MethodImpl] get; }
  }
}
