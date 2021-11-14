// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsFilterRuleFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [ExclusiveTo(typeof (SmsFilterRule))]
  [Guid(12805384, 25238, 20265, 154, 173, 137, 32, 206, 186, 60, 232)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISmsFilterRuleFactory
  {
    SmsFilterRule CreateFilterRule(SmsMessageType messageType);
  }
}
