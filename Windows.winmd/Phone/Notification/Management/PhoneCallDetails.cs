// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.PhoneCallDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  public sealed class PhoneCallDetails : IPhoneCallDetails
  {
    public extern Guid PhoneLine { [MethodImpl] get; }

    public extern uint CallId { [MethodImpl] get; }

    public extern PhoneCallTransport CallTransport { [MethodImpl] get; }

    public extern PhoneMediaType CallMediaType { [MethodImpl] get; }

    public extern PhoneCallDirection CallDirection { [MethodImpl] get; }

    public extern PhoneCallState State { [MethodImpl] get; }

    public extern uint ConferenceCallId { [MethodImpl] get; }

    public extern global::Windows.Foundation.DateTime StartTime { [MethodImpl] get; }

    public extern global::Windows.Foundation.DateTime EndTime { [MethodImpl] get; }

    public extern string PhoneNumber { [MethodImpl] get; }

    public extern string ContactName { [MethodImpl] get; }

    public extern IVectorView<TextResponse> PresetTextResponses { [MethodImpl] get; }
  }
}
