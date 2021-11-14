// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.KnownRemoteSystemCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [Static(typeof (IKnownRemoteSystemCapabilitiesStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public static class KnownRemoteSystemCapabilities
  {
    public static extern string AppService { [MethodImpl] get; }

    public static extern string LaunchUri { [MethodImpl] get; }

    public static extern string RemoteSession { [MethodImpl] get; }

    public static extern string SpatialEntity { [MethodImpl] get; }
  }
}
