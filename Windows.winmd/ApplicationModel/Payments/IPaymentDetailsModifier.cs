// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentDetailsModifier
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ExclusiveTo(typeof (PaymentDetailsModifier))]
  [Guid(3189538149, 17187, 16855, 179, 5, 223, 203, 118, 95, 105, 222)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IPaymentDetailsModifier
  {
    string JsonData { get; }

    IVectorView<string> SupportedMethodIds { get; }

    PaymentItem Total { get; }

    IVectorView<PaymentItem> AdditionalDisplayItems { get; }
  }
}
