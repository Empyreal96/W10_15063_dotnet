// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PaymentDetails))]
  [Guid(1404775805, 57579, 16467, 142, 174, 206, 124, 72, 224, 41, 69)]
  internal interface IPaymentDetails
  {
    PaymentItem Total { get; set; }

    IVectorView<PaymentItem> DisplayItems { get; set; }

    IVectorView<PaymentShippingOption> ShippingOptions { get; set; }

    IVectorView<PaymentDetailsModifier> Modifiers { get; set; }
  }
}
