// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.IPlayToConnection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [ExclusiveTo(typeof (PlayToConnection))]
  [Guid(288341960, 62005, 20446, 141, 65, 155, 242, 124, 158, 154, 64)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("PlayToConnection may be altered or unavailable for releases after Windows 10. Instead, use CastingConnection.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  internal interface IPlayToConnection
  {
    PlayToConnectionState State { [Deprecated("PlayToConnection may be altered or unavailable for releases after Windows 10. Instead, use CastingConnection.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    event TypedEventHandler<PlayToConnection, PlayToConnectionStateChangedEventArgs> StateChanged;

    event TypedEventHandler<PlayToConnection, PlayToConnectionTransferredEventArgs> Transferred;

    event TypedEventHandler<PlayToConnection, PlayToConnectionErrorEventArgs> Error;
  }
}
