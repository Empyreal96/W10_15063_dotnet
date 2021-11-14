// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IKnownRemoteSystemCapabilitiesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [Guid(2164843392, 32650, 17636, 146, 205, 3, 182, 70, 155, 148, 163)]
  [ExclusiveTo(typeof (KnownRemoteSystemCapabilities))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IKnownRemoteSystemCapabilitiesStatics
  {
    string AppService { get; }

    string LaunchUri { get; }

    string RemoteSession { get; }

    string SpatialEntity { get; }
  }
}
