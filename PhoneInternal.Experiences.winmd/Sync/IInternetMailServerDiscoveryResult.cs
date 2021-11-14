// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Sync.IInternetMailServerDiscoveryResult
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Sync
{
  [Version(100859904)]
  [Guid(1696711083, 38487, 16765, 164, 155, 32, 220, 87, 252, 10, 146)]
  [ExclusiveTo(typeof (InternetMailServerDiscoveryResult))]
  internal interface IInternetMailServerDiscoveryResult
  {
    string ServerName { get; }

    ProtocolType SupportProtocolType { get; }

    string IncomingServerUrl { get; }

    uint IncomingServerPort { get; }

    bool IncomingServerUseSsl { get; }

    uint IncomingServerUserNameFormat { get; }

    string OutgoingServerUrl { get; }

    uint OutgoingServerPort { get; }

    bool OutgoingServerUseSsl { get; }

    uint OutgoingServerUserNameFormat { get; }

    bool OutgoingServerAuthRequired { get; }
  }
}
