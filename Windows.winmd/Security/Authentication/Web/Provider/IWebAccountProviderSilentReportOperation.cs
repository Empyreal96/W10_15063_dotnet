// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountProviderSilentReportOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Authentication.Web.Core;

namespace Windows.Security.Authentication.Web.Provider
{
  [Guid(3769976312, 15119, 17626, 146, 76, 123, 24, 186, 170, 98, 169)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IWebAccountProviderSilentReportOperation : IWebAccountProviderBaseReportOperation
  {
    [Overload("ReportUserInteractionRequired")]
    void ReportUserInteractionRequired();

    [Overload("ReportUserInteractionRequiredWithError")]
    void ReportUserInteractionRequired(WebProviderError value);
  }
}
