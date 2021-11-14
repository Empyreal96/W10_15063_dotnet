// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebProviderTokenResponseFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Authentication.Web.Core;

namespace Windows.Security.Authentication.Web.Provider
{
  [ExclusiveTo(typeof (WebProviderTokenResponse))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4199143834, 9658, 16503, 156, 250, 157, 180, 222, 167, 183, 26)]
  internal interface IWebProviderTokenResponseFactory
  {
    WebProviderTokenResponse Create(WebTokenResponse webTokenResponse);
  }
}
