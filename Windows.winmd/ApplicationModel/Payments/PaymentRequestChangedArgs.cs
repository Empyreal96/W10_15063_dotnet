// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentRequestChangedArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class PaymentRequestChangedArgs : IPaymentRequestChangedArgs
  {
    public extern PaymentRequestChangeKind ChangeKind { [MethodImpl] get; }

    public extern PaymentAddress ShippingAddress { [MethodImpl] get; }

    public extern PaymentShippingOption SelectedShippingOption { [MethodImpl] get; }

    [MethodImpl]
    public extern void Acknowledge(PaymentRequestChangedResult changeResult);
  }
}
