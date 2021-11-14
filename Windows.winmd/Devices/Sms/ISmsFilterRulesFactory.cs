// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsFilterRulesFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [ExclusiveTo(typeof (SmsFilterRules))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2694391021, 28206, 17712, 159, 222, 70, 93, 2, 238, 208, 14)]
  internal interface ISmsFilterRulesFactory
  {
    SmsFilterRules CreateFilterRules(SmsFilterActionType actionType);
  }
}
