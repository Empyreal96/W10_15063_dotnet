// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountProviderDeleteAccountOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Security.Authentication.Web.Provider
{
  [ExclusiveTo(typeof (WebAccountProviderDeleteAccountOperation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(180046008, 40449, 18889, 163, 85, 125, 72, 202, 247, 214, 202)]
  internal interface IWebAccountProviderDeleteAccountOperation : IWebAccountProviderOperation
  {
    WebAccount WebAccount { get; }
  }
}
