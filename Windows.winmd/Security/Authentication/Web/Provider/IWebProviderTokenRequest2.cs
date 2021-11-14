// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebProviderTokenRequest2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Authentication.Web.Provider
{
  [Guid(3050778188, 4273, 19110, 136, 177, 11, 108, 158, 12, 30, 70)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (WebProviderTokenRequest))]
  internal interface IWebProviderTokenRequest2
  {
    [RemoteAsync]
    IAsyncOperation<IBuffer> GetApplicationTokenBindingKeyIdAsync(
      TokenBindingKeyType keyType,
      Uri target);
  }
}
