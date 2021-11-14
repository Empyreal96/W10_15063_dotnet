// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.Background.IPhoneCallOriginDataRequestTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls.Background
{
  [Guid(1855675199, 50507, 20098, 76, 201, 227, 41, 164, 24, 69, 146)]
  [ExclusiveTo(typeof (PhoneCallOriginDataRequestTriggerDetails))]
  [ContractVersion(typeof (CallsBackgroundContract), 65536)]
  [PreviousContractVersion("Windows.ApplicationModel.Calls.CallsPhoneContract", 65536, 131072)]
  internal interface IPhoneCallOriginDataRequestTriggerDetails
  {
    Guid RequestId { get; }

    string PhoneNumber { get; }
  }
}
