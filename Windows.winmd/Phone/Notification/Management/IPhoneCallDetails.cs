// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.IPhoneCallDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [Guid(203124563, 61553, 18494, 191, 51, 235, 212, 75, 114, 68, 71)]
  [ExclusiveTo(typeof (PhoneCallDetails))]
  [ContractVersion(typeof (PhoneContract), 65536)]
  internal interface IPhoneCallDetails
  {
    Guid PhoneLine { get; }

    uint CallId { get; }

    PhoneCallTransport CallTransport { get; }

    PhoneMediaType CallMediaType { get; }

    PhoneCallDirection CallDirection { get; }

    PhoneCallState State { get; }

    uint ConferenceCallId { get; }

    global::Windows.Foundation.DateTime StartTime { get; }

    global::Windows.Foundation.DateTime EndTime { get; }

    string PhoneNumber { get; }

    string ContactName { get; }

    IVectorView<TextResponse> PresetTextResponses { get; }
  }
}
