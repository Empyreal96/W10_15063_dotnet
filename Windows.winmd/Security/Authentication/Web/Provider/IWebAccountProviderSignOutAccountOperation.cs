// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountProviderSignOutAccountOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Security.Authentication.Web.Provider
{
  [Guid(3096502813, 3157, 18364, 140, 114, 4, 166, 252, 124, 172, 7)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebAccountProviderSignOutAccountOperation))]
  internal interface IWebAccountProviderSignOutAccountOperation : IWebAccountProviderOperation
  {
    WebAccount WebAccount { get; }

    Uri ApplicationCallbackUri { get; }

    string ClientId { get; }
  }
}
