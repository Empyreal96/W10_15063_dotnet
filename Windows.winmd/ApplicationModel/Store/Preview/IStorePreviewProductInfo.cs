// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.IStorePreviewProductInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview
{
  [Guid(423091123, 27649, 19613, 133, 205, 91, 171, 170, 194, 179, 81)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (StorePreviewProductInfo))]
  internal interface IStorePreviewProductInfo
  {
    string ProductId { get; }

    string ProductType { get; }

    string Title { get; }

    string Description { get; }

    IVectorView<StorePreviewSkuInfo> SkuInfoList { get; }
  }
}
