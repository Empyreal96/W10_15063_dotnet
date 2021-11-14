// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.WebAccountProviderSignOutAccountOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Authentication.Web.Core;
using Windows.Security.Credentials;

namespace Windows.Security.Authentication.Web.Provider
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WebAccountProviderSignOutAccountOperation : 
    IWebAccountProviderSignOutAccountOperation,
    IWebAccountProviderOperation,
    IWebAccountProviderBaseReportOperation
  {
    public extern WebAccount WebAccount { [MethodImpl] get; }

    public extern Uri ApplicationCallbackUri { [MethodImpl] get; }

    public extern string ClientId { [MethodImpl] get; }

    public extern WebAccountProviderOperationKind Kind { [MethodImpl] get; }

    [MethodImpl]
    public extern void ReportCompleted();

    [MethodImpl]
    public extern void ReportError(WebProviderError value);
  }
}
