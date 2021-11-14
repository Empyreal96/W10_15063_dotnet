// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.IStoreLicense
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [ContractVersion(typeof (StoreContract), 65536)]
  [Guid(651990393, 19535, 20272, 188, 137, 100, 159, 96, 227, 96, 85)]
  [ExclusiveTo(typeof (StoreLicense))]
  internal interface IStoreLicense
  {
    string SkuStoreId { get; }

    bool IsActive { get; }

    DateTime ExpirationDate { get; }

    string ExtendedJsonData { get; }

    string InAppOfferToken { get; }
  }
}
