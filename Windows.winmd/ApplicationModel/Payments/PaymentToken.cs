// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentToken
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IPaymentTokenFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class PaymentToken : IPaymentToken
  {
    [MethodImpl]
    public extern PaymentToken(string paymentMethodId);

    [MethodImpl]
    public extern PaymentToken(string paymentMethodId, string jsonDetails);

    public extern string PaymentMethodId { [MethodImpl] get; }

    public extern string JsonDetails { [MethodImpl] get; }
  }
}
