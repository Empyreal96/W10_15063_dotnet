// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.Background.IPhoneNewVoicemailMessageTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls.Background
{
  [Guid(329826331, 47153, 18643, 139, 169, 141, 34, 166, 88, 13, 207)]
  [ContractVersion(typeof (CallsBackgroundContract), 65536)]
  [PreviousContractVersion("Windows.ApplicationModel.Calls.CallsPhoneContract", 65536, 131072)]
  [ExclusiveTo(typeof (PhoneNewVoicemailMessageTriggerDetails))]
  internal interface IPhoneNewVoicemailMessageTriggerDetails
  {
    Guid LineId { get; }

    int VoicemailCount { get; }

    string OperatorMessage { get; }
  }
}
