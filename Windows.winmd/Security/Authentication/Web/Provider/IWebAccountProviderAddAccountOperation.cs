// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountProviderAddAccountOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1944837327, 17272, 19577, 147, 53, 165, 215, 171, 129, 89, 78)]
  [ExclusiveTo(typeof (WebAccountProviderAddAccountOperation))]
  internal interface IWebAccountProviderAddAccountOperation : IWebAccountProviderOperation
  {
    void ReportCompleted();
  }
}
