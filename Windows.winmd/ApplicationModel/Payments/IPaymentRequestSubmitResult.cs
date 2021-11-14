// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentRequestSubmitResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2073835794, 12530, 20112, 178, 73, 140, 231, 215, 143, 254, 86)]
  [ExclusiveTo(typeof (PaymentRequestSubmitResult))]
  internal interface IPaymentRequestSubmitResult
  {
    PaymentRequestStatus Status { get; }

    PaymentResponse Response { get; }
  }
}
