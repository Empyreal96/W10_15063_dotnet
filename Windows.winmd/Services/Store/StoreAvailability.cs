// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.StoreAvailability
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (StoreContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class StoreAvailability : IStoreAvailability
  {
    public extern string StoreId { [MethodImpl] get; }

    public extern DateTime EndDate { [MethodImpl] get; }

    public extern StorePrice Price { [MethodImpl] get; }

    public extern string ExtendedJsonData { [MethodImpl] get; }

    [RemoteAsync]
    [Overload("RequestPurchaseAsync")]
    [MethodImpl]
    public extern IAsyncOperation<StorePurchaseResult> RequestPurchaseAsync();

    [RemoteAsync]
    [Overload("RequestPurchaseWithPurchasePropertiesAsync")]
    [MethodImpl]
    public extern IAsyncOperation<StorePurchaseResult> RequestPurchaseAsync(
      StorePurchaseProperties storePurchaseProperties);
  }
}
