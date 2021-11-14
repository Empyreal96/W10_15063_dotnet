// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.IStorePreviewPurchaseResults
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2967121617, 54981, 20051, 160, 67, 251, 160, 216, 230, 18, 49)]
  [ExclusiveTo(typeof (StorePreviewPurchaseResults))]
  internal interface IStorePreviewPurchaseResults
  {
    StorePreviewProductPurchaseStatus ProductPurchaseStatus { get; }
  }
}
