// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.ICurrentAppStaticsWithFiltering
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CurrentApp))]
  [Guid(3547161922, 36997, 17294, 151, 186, 162, 92, 151, 107, 226, 253)]
  internal interface ICurrentAppStaticsWithFiltering
  {
    IAsyncOperation<ListingInformation> LoadListingInformationByProductIdsAsync(
      IIterable<string> productIds);

    IAsyncOperation<ListingInformation> LoadListingInformationByKeywordsAsync(
      IIterable<string> keywords);

    void ReportProductFulfillment(string productId);
  }
}
