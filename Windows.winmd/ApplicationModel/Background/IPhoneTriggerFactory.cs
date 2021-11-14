// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IPhoneTriggerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.Calls.Background;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [PreviousContractVersion("Windows.ApplicationModel.Calls.CallsPhoneContract", 65536, 131072)]
  [ContractVersion(typeof (CallsBackgroundContract), 65536)]
  [Guid(2698591450, 24513, 18683, 165, 70, 50, 38, 32, 64, 21, 123)]
  [ExclusiveTo(typeof (PhoneTrigger))]
  internal interface IPhoneTriggerFactory
  {
    PhoneTrigger Create(PhoneTriggerType type, bool oneShot);
  }
}
