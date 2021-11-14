// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsMessageRegistrationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [Guid(1671451748, 10392, 18296, 160, 60, 111, 153, 73, 7, 214, 58)]
  [ExclusiveTo(typeof (SmsMessageRegistration))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISmsMessageRegistrationStatics
  {
    IVectorView<SmsMessageRegistration> AllRegistrations { get; }

    SmsMessageRegistration Register(string id, SmsFilterRules filterRules);
  }
}
