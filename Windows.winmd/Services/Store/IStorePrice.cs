// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.IStorePrice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [ContractVersion(typeof (StoreContract), 65536)]
  [Guid(1438291140, 5617, 16508, 143, 6, 0, 99, 128, 244, 223, 11)]
  [ExclusiveTo(typeof (StorePrice))]
  internal interface IStorePrice
  {
    string FormattedBasePrice { get; }

    string FormattedPrice { get; }

    bool IsOnSale { get; }

    DateTime SaleEndDate { get; }

    string CurrencyCode { get; }

    string FormattedRecurrencePrice { get; }
  }
}
