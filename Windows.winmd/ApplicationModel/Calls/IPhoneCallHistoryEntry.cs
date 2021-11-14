// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IPhoneCallHistoryEntry
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [ExclusiveTo(typeof (PhoneCallHistoryEntry))]
  [Guid(4205895977, 12964, 19333, 131, 209, 249, 13, 140, 35, 168, 87)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPhoneCallHistoryEntry
  {
    string Id { get; }

    PhoneCallHistoryEntryAddress Address { get; set; }

    IReference<TimeSpan> Duration { get; set; }

    bool IsCallerIdBlocked { get; set; }

    bool IsEmergency { get; set; }

    bool IsIncoming { get; set; }

    bool IsMissed { get; set; }

    bool IsRinging { get; set; }

    bool IsSeen { get; set; }

    bool IsSuppressed { get; set; }

    bool IsVoicemail { get; set; }

    PhoneCallHistoryEntryMedia Media { get; set; }

    PhoneCallHistoryEntryOtherAppReadAccess OtherAppReadAccess { get; set; }

    string RemoteId { get; set; }

    string SourceDisplayName { get; }

    string SourceId { get; set; }

    PhoneCallHistorySourceIdKind SourceIdKind { get; set; }

    DateTime StartTime { get; set; }
  }
}
