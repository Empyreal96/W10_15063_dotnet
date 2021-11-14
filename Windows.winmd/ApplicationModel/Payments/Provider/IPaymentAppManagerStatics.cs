// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.Provider.IPaymentAppManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments.Provider
{
  [ExclusiveTo(typeof (PaymentAppManager))]
  [Guid(2738990120, 64649, 17414, 180, 217, 52, 231, 254, 121, 223, 182)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IPaymentAppManagerStatics
  {
    PaymentAppManager Current { get; }
  }
}
