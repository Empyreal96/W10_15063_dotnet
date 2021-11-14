// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentRequestChangedHandler
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [Guid(1350089185, 62360, 20268, 162, 126, 148, 211, 113, 207, 108, 125)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public delegate void PaymentRequestChangedHandler(
    PaymentRequest paymentRequest,
    PaymentRequestChangedArgs args);
}
