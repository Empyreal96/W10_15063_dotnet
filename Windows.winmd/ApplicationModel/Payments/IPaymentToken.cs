// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentToken
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [Guid(3150626835, 52432, 16882, 178, 161, 10, 46, 75, 93, 206, 37)]
  [ExclusiveTo(typeof (PaymentToken))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IPaymentToken
  {
    string PaymentMethodId { get; }

    string JsonDetails { get; }
  }
}
