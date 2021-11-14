// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemKindFilter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Activatable(typeof (IRemoteSystemKindFilterFactory), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RemoteSystemKindFilter : IRemoteSystemKindFilter, IRemoteSystemFilter
  {
    [MethodImpl]
    public extern RemoteSystemKindFilter(IIterable<string> remoteSystemKinds);

    public extern IVectorView<string> RemoteSystemKinds { [MethodImpl] get; }
  }
}
