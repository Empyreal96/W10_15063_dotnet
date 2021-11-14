// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountManagerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (WebAccountManager))]
  [Guid(1755818025, 11615, 18003, 139, 176, 189, 47, 166, 189, 45, 135)]
  internal interface IWebAccountManagerStatics2
  {
    [RemoteAsync]
    IAsyncAction PullCookiesAsync(string uriString, string callerPFN);
  }
}
