// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.Background.IPhoneLineChangedTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls.Background
{
  [ContractVersion(typeof (CallsBackgroundContract), 65536)]
  [Guid(3335725543, 53533, 16600, 178, 183, 228, 10, 1, 214, 98, 73)]
  [PreviousContractVersion("Windows.ApplicationModel.Calls.CallsPhoneContract", 65536, 131072)]
  [ExclusiveTo(typeof (PhoneLineChangedTriggerDetails))]
  internal interface IPhoneLineChangedTriggerDetails
  {
    Guid LineId { get; }

    PhoneLineChangeKind ChangeType { get; }

    bool HasLinePropertyChanged(PhoneLineProperties lineProperty);
  }
}
