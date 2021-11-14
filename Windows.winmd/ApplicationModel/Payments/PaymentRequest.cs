﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IPaymentRequestFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class PaymentRequest : IPaymentRequest
  {
    [MethodImpl]
    public extern PaymentRequest(PaymentDetails details, IIterable<PaymentMethodData> methodData);

    [MethodImpl]
    public extern PaymentRequest(
      PaymentDetails details,
      IIterable<PaymentMethodData> methodData,
      PaymentMerchantInfo merchantInfo);

    [MethodImpl]
    public extern PaymentRequest(
      PaymentDetails details,
      IIterable<PaymentMethodData> methodData,
      PaymentMerchantInfo merchantInfo,
      PaymentOptions options);

    public extern PaymentMerchantInfo MerchantInfo { [MethodImpl] get; }

    public extern PaymentDetails Details { [MethodImpl] get; }

    public extern IVectorView<PaymentMethodData> MethodData { [MethodImpl] get; }

    public extern PaymentOptions Options { [MethodImpl] get; }
  }
}
