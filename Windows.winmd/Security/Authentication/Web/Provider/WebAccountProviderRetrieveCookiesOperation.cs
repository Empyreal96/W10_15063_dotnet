// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.WebAccountProviderRetrieveCookiesOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Authentication.Web.Core;
using Windows.Web.Http;

namespace Windows.Security.Authentication.Web.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class WebAccountProviderRetrieveCookiesOperation : 
    IWebAccountProviderRetrieveCookiesOperation,
    IWebAccountProviderOperation,
    IWebAccountProviderBaseReportOperation
  {
    public extern Uri Context { [MethodImpl] get; }

    public extern IVector<HttpCookie> Cookies { [MethodImpl] get; }

    public extern Uri Uri { [MethodImpl] set; [MethodImpl] get; }

    public extern Uri ApplicationCallbackUri { [MethodImpl] get; }

    public extern WebAccountProviderOperationKind Kind { [MethodImpl] get; }

    [MethodImpl]
    public extern void ReportCompleted();

    [MethodImpl]
    public extern void ReportError(WebProviderError value);
  }
}
