// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.Provider.IPaymentAppManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments.Provider
{
  [Guid(239577683, 34081, 18793, 169, 87, 223, 37, 56, 163, 169, 143)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PaymentAppManager))]
  internal interface IPaymentAppManager
  {
    [RemoteAsync]
    IAsyncAction RegisterAsync(IIterable<string> supportedPaymentMethodIds);

    [RemoteAsync]
    IAsyncAction UnregisterAsync();
  }
}
