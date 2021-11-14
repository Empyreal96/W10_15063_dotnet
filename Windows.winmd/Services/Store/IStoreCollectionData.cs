// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.IStoreCollectionData
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [Guid(2326053811, 23475, 17434, 42, 180, 77, 171, 115, 213, 206, 103)]
  [ContractVersion(typeof (StoreContract), 65536)]
  [ExclusiveTo(typeof (StoreCollectionData))]
  internal interface IStoreCollectionData
  {
    bool IsTrial { get; }

    string CampaignId { get; }

    string DeveloperOfferId { get; }

    DateTime AcquiredDate { get; }

    DateTime StartDate { get; }

    DateTime EndDate { get; }

    TimeSpan TrialTimeRemaining { get; }

    string ExtendedJsonData { get; }
  }
}
