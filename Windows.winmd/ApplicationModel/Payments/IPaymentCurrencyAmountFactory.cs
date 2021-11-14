// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentCurrencyAmountFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [Guid(844616504, 5132, 17781, 133, 53, 247, 115, 23, 140, 9, 167)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PaymentCurrencyAmount))]
  internal interface IPaymentCurrencyAmountFactory
  {
    PaymentCurrencyAmount Create(string value, string currency);

    PaymentCurrencyAmount CreateWithCurrencySystem(
      string value,
      string currency,
      string currencySystem);
  }
}
