// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentRequestChangedResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IPaymentRequestChangedResultFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class PaymentRequestChangedResult : IPaymentRequestChangedResult
  {
    [MethodImpl]
    public extern PaymentRequestChangedResult(bool changeAcceptedByMerchant);

    [MethodImpl]
    public extern PaymentRequestChangedResult(
      bool changeAcceptedByMerchant,
      PaymentDetails updatedPaymentDetails);

    public extern bool ChangeAcceptedByMerchant { [MethodImpl] get; [MethodImpl] set; }

    public extern string Message { [MethodImpl] get; [MethodImpl] set; }

    public extern PaymentDetails UpdatedPaymentDetails { [MethodImpl] get; [MethodImpl] set; }
  }
}
