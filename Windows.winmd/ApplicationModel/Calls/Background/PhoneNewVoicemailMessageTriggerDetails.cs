// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.Background.PhoneNewVoicemailMessageTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls.Background
{
  [PreviousContractVersion("Windows.ApplicationModel.Calls.CallsPhoneContract", 65536, 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (CallsBackgroundContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class PhoneNewVoicemailMessageTriggerDetails : 
    IPhoneNewVoicemailMessageTriggerDetails
  {
    public extern Guid LineId { [MethodImpl] get; }

    public extern int VoicemailCount { [MethodImpl] get; }

    public extern string OperatorMessage { [MethodImpl] get; }
  }
}
