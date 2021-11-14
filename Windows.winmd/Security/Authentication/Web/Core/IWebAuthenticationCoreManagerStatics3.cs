// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.IWebAuthenticationCoreManagerStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Security.Authentication.Web.Core
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(604303026, 35108, 19859, 171, 58, 153, 104, 139, 65, 157, 86)]
  [ExclusiveTo(typeof (WebAuthenticationCoreManager))]
  internal interface IWebAuthenticationCoreManagerStatics3 : IWebAuthenticationCoreManagerStatics
  {
    WebAccountMonitor CreateWebAccountMonitor(IIterable<WebAccount> webAccounts);
  }
}
