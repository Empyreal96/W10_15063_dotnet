// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsMessageRegistration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ISmsMessageRegistrationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SmsMessageRegistration : ISmsMessageRegistration
  {
    public extern string Id { [MethodImpl] get; }

    [MethodImpl]
    public extern void Unregister();

    public extern event TypedEventHandler<SmsMessageRegistration, SmsMessageReceivedTriggerDetails> MessageReceived;

    public static extern IVectorView<SmsMessageRegistration> AllRegistrations { [MethodImpl] get; }

    [MethodImpl]
    public static extern SmsMessageRegistration Register(
      string id,
      SmsFilterRules filterRules);
  }
}
