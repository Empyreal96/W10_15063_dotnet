// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.PurchaseResults
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class PurchaseResults : IPurchaseResults
  {
    public extern ProductPurchaseStatus Status { [MethodImpl] get; }

    public extern Guid TransactionId { [MethodImpl] get; }

    public extern string ReceiptXml { [MethodImpl] get; }

    public extern string OfferId { [MethodImpl] get; }
  }
}
