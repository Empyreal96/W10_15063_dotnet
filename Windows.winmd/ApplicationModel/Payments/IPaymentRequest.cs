// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [Guid(3075031777, 60795, 18411, 188, 8, 120, 204, 93, 104, 150, 182)]
  [ExclusiveTo(typeof (PaymentRequest))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IPaymentRequest
  {
    PaymentMerchantInfo MerchantInfo { get; }

    PaymentDetails Details { get; }

    IVectorView<PaymentMethodData> MethodData { get; }

    PaymentOptions Options { get; }
  }
}
