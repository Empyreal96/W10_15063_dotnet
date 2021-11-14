// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.WebAccountProviderGetTokenSilentOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Authentication.Web.Core;

namespace Windows.Security.Authentication.Web.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WebAccountProviderGetTokenSilentOperation : 
    IWebAccountProviderTokenOperation,
    IWebAccountProviderOperation,
    IWebAccountProviderSilentReportOperation,
    IWebAccountProviderBaseReportOperation
  {
    public extern WebProviderTokenRequest ProviderRequest { [MethodImpl] get; }

    public extern IVector<WebProviderTokenResponse> ProviderResponses { [MethodImpl] get; }

    public extern DateTime CacheExpirationTime { [MethodImpl] set; [MethodImpl] get; }

    public extern WebAccountProviderOperationKind Kind { [MethodImpl] get; }

    [Overload("ReportUserInteractionRequired")]
    [MethodImpl]
    public extern void ReportUserInteractionRequired();

    [Overload("ReportUserInteractionRequiredWithError")]
    [MethodImpl]
    public extern void ReportUserInteractionRequired(WebProviderError value);

    [MethodImpl]
    public extern void ReportCompleted();

    [MethodImpl]
    public extern void ReportError(WebProviderError value);
  }
}
