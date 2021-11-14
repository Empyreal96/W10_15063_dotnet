// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.AppDiscovery.IVoipExtensionData
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.AppDiscovery
{
  [Version(100859904)]
  [ExclusiveTo(typeof (VoipExtensionData))]
  [Guid(3343574215, 53646, 15846, 135, 11, 200, 143, 42, 76, 206, 227)]
  internal interface IVoipExtensionData
  {
    bool HasUserSignInQuery { get; }

    bool HasReverseLookupByPhoneNumber { get; }

    bool HasReverseLookupByEmailAddress { get; }

    bool HasMobileVerifiedNumber { get; }

    bool HasQueryPresenceByVoipId { get; }

    bool HasQueryPresenceByPhoneNumber { get; }

    bool HasQueryPresenceByEmailAddress { get; }

    bool HasRealtimePresenceByVoipId { get; }

    bool HasRealtimePresenceByPhoneNumber { get; }

    bool HasRealtimePresenceByEmailAddress { get; }

    bool HasSeamlessEscalation { get; }
  }
}
