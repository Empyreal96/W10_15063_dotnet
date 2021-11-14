// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.Background.PhoneCallOriginDataRequestTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls.Background
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (CallsBackgroundContract), 65536)]
  [PreviousContractVersion("Windows.ApplicationModel.Calls.CallsPhoneContract", 65536, 131072)]
  public sealed class PhoneCallOriginDataRequestTriggerDetails : 
    IPhoneCallOriginDataRequestTriggerDetails
  {
    public extern Guid RequestId { [MethodImpl] get; }

    public extern string PhoneNumber { [MethodImpl] get; }
  }
}
