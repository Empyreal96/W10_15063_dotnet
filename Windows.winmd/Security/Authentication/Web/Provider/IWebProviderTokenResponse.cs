// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebProviderTokenResponse
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
  [Guid(4011931539, 61269, 16774, 183, 206, 140, 178, 231, 249, 132, 158)]
  internal interface IWebProviderTokenResponse
  {
    WebTokenResponse ClientResponse { get; }
  }
}
