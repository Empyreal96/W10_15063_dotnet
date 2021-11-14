// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Sync.InternetMailServerDiscoveryResult
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Sync
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Version(100859904)]
  [Activatable(100859904)]
  [Threading(ThreadingModel.Both)]
  public sealed class InternetMailServerDiscoveryResult : IInternetMailServerDiscoveryResult
  {
    [MethodImpl]
    public extern InternetMailServerDiscoveryResult();

    public extern string ServerName { [MethodImpl] get; }

    public extern ProtocolType SupportProtocolType { [MethodImpl] get; }

    public extern string IncomingServerUrl { [MethodImpl] get; }

    public extern uint IncomingServerPort { [MethodImpl] get; }

    public extern bool IncomingServerUseSsl { [MethodImpl] get; }

    public extern uint IncomingServerUserNameFormat { [MethodImpl] get; }

    public extern string OutgoingServerUrl { [MethodImpl] get; }

    public extern uint OutgoingServerPort { [MethodImpl] get; }

    public extern bool OutgoingServerUseSsl { [MethodImpl] get; }

    public extern uint OutgoingServerUserNameFormat { [MethodImpl] get; }

    public extern bool OutgoingServerAuthRequired { [MethodImpl] get; }
  }
}
