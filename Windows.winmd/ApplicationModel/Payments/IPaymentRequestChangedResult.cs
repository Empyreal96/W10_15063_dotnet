// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentRequestChangedResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [Guid(3748240988, 5828, 18349, 148, 1, 132, 64, 236, 7, 87, 219)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PaymentRequestChangedResult))]
  internal interface IPaymentRequestChangedResult
  {
    bool ChangeAcceptedByMerchant { get; set; }

    string Message { get; set; }

    PaymentDetails UpdatedPaymentDetails { get; set; }
  }
}
