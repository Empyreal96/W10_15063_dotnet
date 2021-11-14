// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.IStorePreviewSkuInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview
{
  [Guid(2180871906, 2854, 18649, 152, 206, 39, 70, 28, 102, 157, 108)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (StorePreviewSkuInfo))]
  internal interface IStorePreviewSkuInfo
  {
    string ProductId { get; }

    string SkuId { get; }

    string SkuType { get; }

    string Title { get; }

    string Description { get; }

    string CustomDeveloperData { get; }

    string CurrencyCode { get; }

    string FormattedListPrice { get; }

    string ExtendedData { get; }
  }
}
