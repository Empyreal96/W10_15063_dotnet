// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentTokenFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ExclusiveTo(typeof (PaymentToken))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2559367082, 18259, 18692, 131, 115, 221, 123, 8, 185, 149, 193)]
  internal interface IPaymentTokenFactory
  {
    PaymentToken Create(string paymentMethodId);

    PaymentToken CreateWithJsonDetails(string paymentMethodId, string jsonDetails);
  }
}
