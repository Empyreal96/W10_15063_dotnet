// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsDevice2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ISmsDevice2Statics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SmsDevice2 : ISmsDevice2
  {
    public extern string SmscAddress { [MethodImpl] get; [MethodImpl] set; }

    public extern string DeviceId { [MethodImpl] get; }

    public extern string ParentDeviceId { [MethodImpl] get; }

    public extern string AccountPhoneNumber { [MethodImpl] get; }

    public extern CellularClass CellularClass { [MethodImpl] get; }

    public extern SmsDeviceStatus DeviceStatus { [MethodImpl] get; }

    [MethodImpl]
    public extern SmsEncodedLength CalculateLength(ISmsMessageBase message);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SmsSendMessageResult> SendMessageAndGetResultAsync(
      ISmsMessageBase message);

    public extern event TypedEventHandler<SmsDevice2, object> DeviceStatusChanged;

    [MethodImpl]
    public static extern string GetDeviceSelector();

    [MethodImpl]
    public static extern SmsDevice2 FromId(string deviceId);

    [MethodImpl]
    public static extern SmsDevice2 GetDefault();

    [MethodImpl]
    public static extern SmsDevice2 FromParentId(string parentDeviceId);
  }
}
