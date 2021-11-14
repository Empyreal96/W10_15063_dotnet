// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentCurrencyAmount
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PaymentCurrencyAmount))]
  [Guid(3819170272, 46111, 18823, 189, 203, 7, 19, 49, 242, 218, 164)]
  internal interface IPaymentCurrencyAmount
  {
    string Currency { get; set; }

    string CurrencySystem { get; set; }

    string Value { get; set; }
  }
}
