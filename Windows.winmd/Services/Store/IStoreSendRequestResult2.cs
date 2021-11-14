// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.IStoreSendRequestResult2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;
using Windows.Web.Http;

namespace Windows.Services.Store
{
  [ContractVersion(typeof (StoreContract), 131072)]
  [Guid(687941999, 49328, 18896, 142, 141, 170, 148, 10, 249, 193, 11)]
  [ExclusiveTo(typeof (StoreSendRequestResult))]
  internal interface IStoreSendRequestResult2
  {
    HttpStatusCode HttpStatusCode { get; }
  }
}
