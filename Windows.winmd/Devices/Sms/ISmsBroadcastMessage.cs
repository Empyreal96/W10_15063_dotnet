// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsBroadcastMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [ExclusiveTo(typeof (SmsBroadcastMessage))]
  [Guid(1974385649, 58551, 18548, 160, 156, 41, 86, 229, 146, 249, 87)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISmsBroadcastMessage : ISmsMessageBase
  {
    DateTime Timestamp { get; }

    string To { get; }

    string Body { get; }

    int Channel { get; }

    SmsGeographicalScope GeographicalScope { get; }

    int MessageCode { get; }

    int UpdateNumber { get; }

    SmsBroadcastType BroadcastType { get; }

    bool IsEmergencyAlert { get; }

    bool IsUserPopupRequested { get; }
  }
}
