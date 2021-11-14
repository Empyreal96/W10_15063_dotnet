// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.IProductListing2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [ExclusiveTo(typeof (ProductListing))]
  [Guid(4171114767, 29694, 18765, 169, 57, 8, 169, 178, 73, 90, 190)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IProductListing2
  {
    string FormattedBasePrice { get; }

    DateTime SaleEndDate { get; }

    bool IsOnSale { get; }

    string CurrencyCode { get; }
  }
}
