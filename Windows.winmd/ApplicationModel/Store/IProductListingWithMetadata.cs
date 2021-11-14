// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.IProductListingWithMetadata
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [Guid(307078503, 9208, 16958, 149, 50, 24, 153, 67, 196, 10, 206)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ProductListing))]
  internal interface IProductListingWithMetadata : IProductListing
  {
    string Description { get; }

    IIterable<string> Keywords { get; }

    ProductType ProductType { get; }

    string Tag { get; }

    Uri ImageUri { get; }
  }
}
