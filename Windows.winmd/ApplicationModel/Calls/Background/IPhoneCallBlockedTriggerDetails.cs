// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.Background.IPhoneCallBlockedTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls.Background
{
  [PreviousContractVersion("Windows.ApplicationModel.Calls.CallsPhoneContract", 65536, 131072)]
  [Guid(2762379426, 58561, 17023, 134, 78, 228, 112, 71, 125, 219, 103)]
  [ContractVersion(typeof (CallsBackgroundContract), 65536)]
  [ExclusiveTo(typeof (PhoneCallBlockedTriggerDetails))]
  internal interface IPhoneCallBlockedTriggerDetails
  {
    string PhoneNumber { get; }

    Guid LineId { get; }

    PhoneCallBlockedReason CallBlockedReason { get; }
  }
}
