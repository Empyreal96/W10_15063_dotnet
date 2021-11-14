// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentResponse
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PaymentResponse : IPaymentResponse
  {
    public extern PaymentToken PaymentToken { [MethodImpl] get; }

    public extern PaymentShippingOption ShippingOption { [MethodImpl] get; }

    public extern PaymentAddress ShippingAddress { [MethodImpl] get; }

    public extern string PayerEmail { [MethodImpl] get; }

    public extern string PayerName { [MethodImpl] get; }

    public extern string PayerPhoneNumber { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction CompleteAsync(PaymentRequestCompletionStatus status);
  }
}
