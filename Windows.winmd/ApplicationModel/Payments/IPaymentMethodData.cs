// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentMethodData
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3520318196, 56984, 16681, 177, 183, 195, 173, 134, 35, 123, 244)]
  [ExclusiveTo(typeof (PaymentMethodData))]
  internal interface IPaymentMethodData
  {
    IVectorView<string> SupportedMethodIds { get; }

    string JsonData { get; }
  }
}
