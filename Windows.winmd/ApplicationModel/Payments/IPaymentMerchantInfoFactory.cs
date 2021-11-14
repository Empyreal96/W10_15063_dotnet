// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentMerchantInfoFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ExclusiveTo(typeof (PaymentMerchantInfo))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2659831507, 52407, 16743, 168, 236, 225, 10, 233, 109, 188, 209)]
  internal interface IPaymentMerchantInfoFactory
  {
    PaymentMerchantInfo Create(Uri uri);
  }
}
