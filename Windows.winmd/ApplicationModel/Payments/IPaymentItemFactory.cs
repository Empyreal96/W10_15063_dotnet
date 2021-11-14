// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentItemFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [Guid(3333126872, 9475, 19741, 167, 120, 2, 178, 229, 146, 123, 44)]
  [ExclusiveTo(typeof (PaymentItem))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IPaymentItemFactory
  {
    PaymentItem Create(string label, PaymentCurrencyAmount amount);
  }
}
