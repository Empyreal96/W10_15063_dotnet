// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentResponse
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ExclusiveTo(typeof (PaymentResponse))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3778581591, 35794, 18568, 159, 168, 151, 152, 85, 69, 16, 142)]
  internal interface IPaymentResponse
  {
    PaymentToken PaymentToken { get; }

    PaymentShippingOption ShippingOption { get; }

    PaymentAddress ShippingAddress { get; }

    string PayerEmail { get; }

    string PayerName { get; }

    string PayerPhoneNumber { get; }

    [RemoteAsync]
    IAsyncAction CompleteAsync(PaymentRequestCompletionStatus status);
  }
}
