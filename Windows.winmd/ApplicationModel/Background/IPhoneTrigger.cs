// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IPhoneTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.Calls.Background;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(2379213211, 54469, 18929, 183, 211, 130, 232, 122, 14, 157, 222)]
  [ExclusiveTo(typeof (PhoneTrigger))]
  [PreviousContractVersion("Windows.ApplicationModel.Calls.CallsPhoneContract", 65536, 131072)]
  [ContractVersion(typeof (CallsBackgroundContract), 65536)]
  internal interface IPhoneTrigger : IBackgroundTrigger
  {
    bool OneShot { get; }

    PhoneTriggerType TriggerType { get; }
  }
}
