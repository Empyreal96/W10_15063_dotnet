// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentAddress
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
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class PaymentAddress : IPaymentAddress
  {
    [MethodImpl]
    public extern PaymentAddress();

    public extern string Country { [MethodImpl] get; [MethodImpl] set; }

    public extern IVectorView<string> AddressLines { [MethodImpl] get; [MethodImpl] set; }

    public extern string Region { [MethodImpl] get; [MethodImpl] set; }

    public extern string City { [MethodImpl] get; [MethodImpl] set; }

    public extern string DependentLocality { [MethodImpl] get; [MethodImpl] set; }

    public extern string PostalCode { [MethodImpl] get; [MethodImpl] set; }

    public extern string SortingCode { [MethodImpl] get; [MethodImpl] set; }

    public extern string LanguageCode { [MethodImpl] get; [MethodImpl] set; }

    public extern string Organization { [MethodImpl] get; [MethodImpl] set; }

    public extern string Recipient { [MethodImpl] get; [MethodImpl] set; }

    public extern string PhoneNumber { [MethodImpl] get; [MethodImpl] set; }

    public extern ValueSet Properties { [MethodImpl] get; }
  }
}
