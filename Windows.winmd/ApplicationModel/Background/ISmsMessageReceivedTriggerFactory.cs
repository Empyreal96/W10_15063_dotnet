// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ISmsMessageReceivedTriggerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Sms;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SmsMessageReceivedTrigger))]
  [Guid(3929725128, 27556, 19122, 141, 33, 188, 107, 9, 199, 117, 100)]
  internal interface ISmsMessageReceivedTriggerFactory
  {
    SmsMessageReceivedTrigger Create(SmsFilterRules filterRules);
  }
}
