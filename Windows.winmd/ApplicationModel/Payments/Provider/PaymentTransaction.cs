// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.Provider.PaymentTransaction
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments.Provider
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IPaymentTransactionStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class PaymentTransaction : IPaymentTransaction
  {
    public extern PaymentRequest PaymentRequest { [MethodImpl] get; }

    public extern string PayerEmail { [MethodImpl] get; [MethodImpl] set; }

    public extern string PayerName { [MethodImpl] get; [MethodImpl] set; }

    public extern string PayerPhoneNumber { [MethodImpl] get; [MethodImpl] set; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PaymentRequestChangedResult> UpdateShippingAddressAsync(
      PaymentAddress shippingAddress);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PaymentRequestChangedResult> UpdateSelectedShippingOptionAsync(
      PaymentShippingOption selectedShippingOption);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PaymentTransactionAcceptResult> AcceptAsync(
      PaymentToken paymentToken);

    [MethodImpl]
    public extern void Reject();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<PaymentTransaction> FromIdAsync(
      string id);
  }
}
