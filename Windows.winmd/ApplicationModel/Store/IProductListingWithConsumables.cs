// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.IProductListingWithConsumables
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [Guid(3953039248, 36715, 18463, 147, 167, 92, 58, 99, 6, 129, 73)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ProductListing))]
  internal interface IProductListingWithConsumables
  {
    ProductType ProductType { get; }
  }
}
