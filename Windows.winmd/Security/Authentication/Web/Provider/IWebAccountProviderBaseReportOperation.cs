// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountProviderBaseReportOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Authentication.Web.Core;

namespace Windows.Security.Authentication.Web.Provider
{
  [Guid(3148131515, 39227, 19799, 187, 228, 20, 33, 227, 102, 139, 76)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IWebAccountProviderBaseReportOperation
  {
    void ReportCompleted();

    void ReportError(WebProviderError value);
  }
}
