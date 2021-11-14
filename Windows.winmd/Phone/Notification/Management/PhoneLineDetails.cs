// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.PhoneLineDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  public sealed class PhoneLineDetails : IPhoneLineDetails, IPhoneLineDetails2
  {
    public extern Guid LineId { [MethodImpl] get; }

    public extern string DisplayName { [MethodImpl] get; }

    public extern string LineNumber { [MethodImpl] get; }

    public extern bool DefaultOutgoingLine { [MethodImpl] get; }

    public extern uint VoicemailCount { [MethodImpl] get; }

    public extern PhoneLineRegistrationState RegistrationState { [MethodImpl] get; }

    public extern uint MissedCallCount { [MethodImpl] get; }
  }
}
