// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ExclusiveTo(typeof (PaymentItem))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1750780043, 31154, 19318, 158, 3, 168, 118, 34, 61, 254, 114)]
  internal interface IPaymentItem
  {
    string Label { get; set; }

    PaymentCurrencyAmount Amount { get; set; }

    bool Pending { get; set; }
  }
}
