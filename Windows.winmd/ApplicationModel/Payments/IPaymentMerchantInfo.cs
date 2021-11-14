// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentMerchantInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PaymentMerchantInfo))]
  [Guid(1665421392, 3732, 20182, 170, 203, 230, 1, 43, 211, 39, 167)]
  internal interface IPaymentMerchantInfo
  {
    string PackageFullName { get; }

    Uri Uri { get; }
  }
}
