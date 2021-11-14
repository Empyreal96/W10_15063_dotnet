// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.PlayToConnection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Deprecated("PlayToConnection may be altered or unavailable for releases after Windows 10. Instead, use CastingConnection.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PlayToConnection : IPlayToConnection
  {
    public extern PlayToConnectionState State { [Deprecated("PlayToConnection may be altered or unavailable for releases after Windows 10. Instead, use CastingConnection.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern event TypedEventHandler<PlayToConnection, PlayToConnectionStateChangedEventArgs> StateChanged;

    public extern event TypedEventHandler<PlayToConnection, PlayToConnectionTransferredEventArgs> Transferred;

    public extern event TypedEventHandler<PlayToConnection, PlayToConnectionErrorEventArgs> Error;
  }
}
