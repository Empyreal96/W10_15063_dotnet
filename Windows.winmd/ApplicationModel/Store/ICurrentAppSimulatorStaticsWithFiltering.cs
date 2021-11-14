// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.ICurrentAppSimulatorStaticsWithFiltering
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CurrentAppSimulator))]
  [Guid(1635676386, 63599, 19284, 150, 102, 221, 226, 133, 9, 44, 104)]
  internal interface ICurrentAppSimulatorStaticsWithFiltering
  {
    IAsyncOperation<ListingInformation> LoadListingInformationByProductIdsAsync(
      IIterable<string> productIds);

    IAsyncOperation<ListingInformation> LoadListingInformationByKeywordsAsync(
      IIterable<string> keywords);
  }
}
