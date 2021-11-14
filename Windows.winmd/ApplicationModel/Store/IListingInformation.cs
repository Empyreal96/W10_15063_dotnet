// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.IListingInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [Guid(1485523647, 48244, 17283, 183, 140, 153, 96, 99, 35, 222, 206)]
  [ExclusiveTo(typeof (ListingInformation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IListingInformation
  {
    string CurrentMarket { get; }

    string Description { get; }

    IMapView<string, ProductListing> ProductListings { get; }

    string FormattedPrice { get; }

    string Name { get; }

    uint AgeRating { get; }
  }
}
