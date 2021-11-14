// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.IStoreAppLicense
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [ContractVersion(typeof (StoreContract), 65536)]
  [ExclusiveTo(typeof (StoreAppLicense))]
  [Guid(4085905886, 29632, 17870, 155, 171, 178, 254, 62, 94, 175, 211)]
  internal interface IStoreAppLicense
  {
    string SkuStoreId { get; }

    bool IsActive { get; }

    bool IsTrial { get; }

    DateTime ExpirationDate { get; }

    string ExtendedJsonData { get; }

    IMapView<string, StoreLicense> AddOnLicenses { get; }

    TimeSpan TrialTimeRemaining { get; }

    bool IsTrialOwnedByThisUser { get; }

    string TrialUniqueId { get; }
  }
}
