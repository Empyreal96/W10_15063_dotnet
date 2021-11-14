// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.IStorePreview
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2316661313, 33806, 18857, 188, 1, 93, 91, 1, 251, 200, 233)]
  [ExclusiveTo(typeof (StorePreview))]
  internal interface IStorePreview
  {
    [RemoteAsync]
    IAsyncOperation<StorePreviewPurchaseResults> RequestProductPurchaseByProductIdAndSkuIdAsync(
      string productId,
      string skuId);

    [RemoteAsync]
    IAsyncOperation<IVectorView<StorePreviewProductInfo>> LoadAddOnProductInfosAsync();
  }
}
