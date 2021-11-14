// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.IListingInformation2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [Guid(3237817373, 45838, 17284, 132, 234, 114, 254, 250, 130, 34, 62)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (ListingInformation))]
  internal interface IListingInformation2
  {
    string FormattedBasePrice { get; }

    DateTime SaleEndDate { get; }

    bool IsOnSale { get; }

    string CurrencyCode { get; }
  }
}
