// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.IPurchaseResults
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [Guid(3981489022, 34390, 20325, 184, 200, 172, 126, 12, 177, 161, 194)]
  [ExclusiveTo(typeof (PurchaseResults))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPurchaseResults
  {
    ProductPurchaseStatus Status { get; }

    Guid TransactionId { get; }

    string ReceiptXml { get; }

    string OfferId { get; }
  }
}
