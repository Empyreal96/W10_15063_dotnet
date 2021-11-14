// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.Provider.IPaymentTransactionStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments.Provider
{
  [ExclusiveTo(typeof (PaymentTransaction))]
  [Guid(2372114256, 60938, 19957, 155, 30, 28, 15, 158, 197, 152, 129)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IPaymentTransactionStatics
  {
    [RemoteAsync]
    IAsyncOperation<PaymentTransaction> FromIdAsync(string id);
  }
}
