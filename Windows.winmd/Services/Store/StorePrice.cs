// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.StorePrice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (StoreContract), 65536)]
  public sealed class StorePrice : IStorePrice
  {
    public extern string FormattedBasePrice { [MethodImpl] get; }

    public extern string FormattedPrice { [MethodImpl] get; }

    public extern bool IsOnSale { [MethodImpl] get; }

    public extern DateTime SaleEndDate { [MethodImpl] get; }

    public extern string CurrencyCode { [MethodImpl] get; }

    public extern string FormattedRecurrencePrice { [MethodImpl] get; }
  }
}
