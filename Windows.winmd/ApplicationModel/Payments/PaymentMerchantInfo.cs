// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentMerchantInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Activatable(typeof (IPaymentMerchantInfoFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PaymentMerchantInfo : IPaymentMerchantInfo
  {
    [MethodImpl]
    public extern PaymentMerchantInfo(Uri uri);

    [MethodImpl]
    public extern PaymentMerchantInfo();

    public extern string PackageFullName { [MethodImpl] get; }

    public extern Uri Uri { [MethodImpl] get; }
  }
}
