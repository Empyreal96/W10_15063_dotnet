// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentMethodDataFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2329793151, 39850, 19074, 131, 66, 168, 33, 9, 146, 163, 107)]
  [ExclusiveTo(typeof (PaymentMethodData))]
  internal interface IPaymentMethodDataFactory
  {
    PaymentMethodData Create(IIterable<string> supportedMethodIds);

    PaymentMethodData CreateWithJsonData(
      IIterable<string> supportedMethodIds,
      string jsonData);
  }
}
