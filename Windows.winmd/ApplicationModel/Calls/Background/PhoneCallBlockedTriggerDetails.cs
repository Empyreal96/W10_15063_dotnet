// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.Background.PhoneCallBlockedTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls.Background
{
  [ContractVersion(typeof (CallsBackgroundContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [PreviousContractVersion("Windows.ApplicationModel.Calls.CallsPhoneContract", 65536, 131072)]
  public sealed class PhoneCallBlockedTriggerDetails : IPhoneCallBlockedTriggerDetails
  {
    public extern string PhoneNumber { [MethodImpl] get; }

    public extern Guid LineId { [MethodImpl] get; }

    public extern PhoneCallBlockedReason CallBlockedReason { [MethodImpl] get; }
  }
}
