// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.Provider.PaymentAppManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IPaymentAppManagerStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class PaymentAppManager : IPaymentAppManager
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RegisterAsync(IIterable<string> supportedPaymentMethodIds);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction UnregisterAsync();

    public static extern PaymentAppManager Current { [MethodImpl] get; }
  }
}
