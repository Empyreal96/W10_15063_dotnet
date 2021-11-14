// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsFilterRules
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SmsFilterRules))]
  [Guid(1313336059, 31181, 18561, 152, 148, 85, 164, 19, 91, 35, 250)]
  internal interface ISmsFilterRules
  {
    SmsFilterActionType ActionType { get; }

    IVector<SmsFilterRule> Rules { get; }
  }
}
