// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountProviderManageAccountOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Security.Authentication.Web.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebAccountProviderManageAccountOperation))]
  [Guid(3978353756, 53787, 17982, 169, 183, 193, 253, 14, 218, 233, 120)]
  internal interface IWebAccountProviderManageAccountOperation : IWebAccountProviderOperation
  {
    WebAccount WebAccount { get; }

    void ReportCompleted();
  }
}
