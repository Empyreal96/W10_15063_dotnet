// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentRequestChangedArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [Guid(3323223620, 52619, 19428, 181, 85, 39, 201, 145, 148, 192, 197)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PaymentRequestChangedArgs))]
  internal interface IPaymentRequestChangedArgs
  {
    PaymentRequestChangeKind ChangeKind { get; }

    PaymentAddress ShippingAddress { get; }

    PaymentShippingOption SelectedShippingOption { get; }

    void Acknowledge(PaymentRequestChangedResult changeResult);
  }
}
