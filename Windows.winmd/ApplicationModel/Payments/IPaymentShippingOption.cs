// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentShippingOption
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [Guid(322382554, 38739, 17780, 137, 102, 147, 20, 90, 118, 199, 249)]
  [ExclusiveTo(typeof (PaymentShippingOption))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IPaymentShippingOption
  {
    string Label { get; set; }

    PaymentCurrencyAmount Amount { get; set; }

    string Tag { get; set; }

    bool IsSelected { get; set; }
  }
}
