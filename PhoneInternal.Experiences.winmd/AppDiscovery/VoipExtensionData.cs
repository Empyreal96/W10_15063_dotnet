// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.AppDiscovery.VoipExtensionData
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.AppDiscovery
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Version(100859904)]
  public sealed class VoipExtensionData : IExtensionData, IVoipExtensionData
  {
    public extern ExtensionID Id { [MethodImpl] get; }

    public extern bool HasUserSignInQuery { [MethodImpl] get; }

    public extern bool HasReverseLookupByPhoneNumber { [MethodImpl] get; }

    public extern bool HasReverseLookupByEmailAddress { [MethodImpl] get; }

    public extern bool HasMobileVerifiedNumber { [MethodImpl] get; }

    public extern bool HasQueryPresenceByVoipId { [MethodImpl] get; }

    public extern bool HasQueryPresenceByPhoneNumber { [MethodImpl] get; }

    public extern bool HasQueryPresenceByEmailAddress { [MethodImpl] get; }

    public extern bool HasRealtimePresenceByVoipId { [MethodImpl] get; }

    public extern bool HasRealtimePresenceByPhoneNumber { [MethodImpl] get; }

    public extern bool HasRealtimePresenceByEmailAddress { [MethodImpl] get; }

    public extern bool HasSeamlessEscalation { [MethodImpl] get; }
  }
}
