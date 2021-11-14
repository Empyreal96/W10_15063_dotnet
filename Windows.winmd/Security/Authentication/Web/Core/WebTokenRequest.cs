// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.WebTokenRequest
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
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IWebTokenRequestFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class WebTokenRequest : IWebTokenRequest, IWebTokenRequest2, IWebTokenRequest3
  {
    [MethodImpl]
    public extern WebTokenRequest(WebAccountProvider provider, string scope, string clientId);

    [MethodImpl]
    public extern WebTokenRequest(
      WebAccountProvider provider,
      string scope,
      string clientId,
      WebTokenRequestPromptType promptType);

    [MethodImpl]
    public extern WebTokenRequest(WebAccountProvider provider);

    [MethodImpl]
    public extern WebTokenRequest(WebAccountProvider provider, string scope);

    public extern WebAccountProvider WebAccountProvider { [MethodImpl] get; }

    public extern string Scope { [MethodImpl] get; }

    public extern string ClientId { [MethodImpl] get; }

    public extern WebTokenRequestPromptType PromptType { [MethodImpl] get; }

    public extern IMap<string, string> Properties { [MethodImpl] get; }

    public extern IMap<string, string> AppProperties { [MethodImpl] get; }

    public extern string CorrelationId { [MethodImpl] get; [MethodImpl] set; }
  }
}
