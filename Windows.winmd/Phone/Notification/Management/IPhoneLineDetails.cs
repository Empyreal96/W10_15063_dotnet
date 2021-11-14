// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.IPhoneLineDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [ExclusiveTo(typeof (PhoneLineDetails))]
  [Guid(1206596316, 13293, 18873, 153, 92, 162, 150, 186, 200, 43, 119)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  internal interface IPhoneLineDetails
  {
    Guid LineId { get; }

    string DisplayName { get; }

    string LineNumber { get; }

    bool DefaultOutgoingLine { get; }

    uint VoicemailCount { get; }

    PhoneLineRegistrationState RegistrationState { get; }
  }
}
