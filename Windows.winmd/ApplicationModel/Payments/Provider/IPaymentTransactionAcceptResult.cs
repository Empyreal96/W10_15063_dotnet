// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.Provider.IPaymentTransactionAcceptResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PaymentTransactionAcceptResult))]
  [Guid(101593718, 54028, 18455, 149, 162, 223, 122, 233, 39, 59, 86)]
  internal interface IPaymentTransactionAcceptResult
  {
    PaymentRequestCompletionStatus Status { get; }
  }
}
