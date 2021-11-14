// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.Provider.IPaymentTransaction
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments.Provider
{
  [Guid(1649941920, 9893, 20123, 166, 235, 102, 96, 108, 240, 1, 211)]
  [ExclusiveTo(typeof (PaymentTransaction))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IPaymentTransaction
  {
    PaymentRequest PaymentRequest { get; }

    string PayerEmail { get; set; }

    string PayerName { get; set; }

    string PayerPhoneNumber { get; set; }

    [RemoteAsync]
    IAsyncOperation<PaymentRequestChangedResult> UpdateShippingAddressAsync(
      PaymentAddress shippingAddress);

    [RemoteAsync]
    IAsyncOperation<PaymentRequestChangedResult> UpdateSelectedShippingOptionAsync(
      PaymentShippingOption selectedShippingOption);

    [RemoteAsync]
    IAsyncOperation<PaymentTransactionAcceptResult> AcceptAsync(
      PaymentToken paymentToken);

    void Reject();
  }
}
