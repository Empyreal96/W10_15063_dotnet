// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemConnectionRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IRemoteSystemConnectionRequestFactory), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class RemoteSystemConnectionRequest : IRemoteSystemConnectionRequest
  {
    [MethodImpl]
    public extern RemoteSystemConnectionRequest(RemoteSystem remoteSystem);

    public extern RemoteSystem RemoteSystem { [MethodImpl] get; }
  }
}
