// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentMethodData
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IPaymentMethodDataFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class PaymentMethodData : IPaymentMethodData
  {
    [MethodImpl]
    public extern PaymentMethodData(IIterable<string> supportedMethodIds);

    [MethodImpl]
    public extern PaymentMethodData(IIterable<string> supportedMethodIds, string jsonData);

    public extern IVectorView<string> SupportedMethodIds { [MethodImpl] get; }

    public extern string JsonData { [MethodImpl] get; }
  }
}
