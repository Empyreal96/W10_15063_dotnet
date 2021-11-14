// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.PhoneCallHistoryEntry
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PhoneCallHistoryEntry : IPhoneCallHistoryEntry
  {
    [MethodImpl]
    public extern PhoneCallHistoryEntry();

    public extern string Id { [MethodImpl] get; }

    public extern PhoneCallHistoryEntryAddress Address { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<TimeSpan> Duration { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsCallerIdBlocked { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsEmergency { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsIncoming { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsMissed { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsRinging { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsSeen { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsSuppressed { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsVoicemail { [MethodImpl] get; [MethodImpl] set; }

    public extern PhoneCallHistoryEntryMedia Media { [MethodImpl] get; [MethodImpl] set; }

    public extern PhoneCallHistoryEntryOtherAppReadAccess OtherAppReadAccess { [MethodImpl] get; [MethodImpl] set; }

    public extern string RemoteId { [MethodImpl] get; [MethodImpl] set; }

    public extern string SourceDisplayName { [MethodImpl] get; }

    public extern string SourceId { [MethodImpl] get; [MethodImpl] set; }

    public extern PhoneCallHistorySourceIdKind SourceIdKind { [MethodImpl] get; [MethodImpl] set; }

    public extern DateTime StartTime { [MethodImpl] get; [MethodImpl] set; }
  }
}
