// Decompiled with JetBrains decompiler
// Type: Windows.Media.Casting.CastingConnection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Casting
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class CastingConnection : ICastingConnection, IClosable
  {
    public extern CastingConnectionState State { [MethodImpl] get; }

    public extern CastingDevice Device { [MethodImpl] get; }

    public extern CastingSource Source { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<CastingConnection, object> StateChanged;

    public extern event TypedEventHandler<CastingConnection, CastingConnectionErrorOccurredEventArgs> ErrorOccurred;

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<CastingConnectionErrorStatus> RequestStartCastingAsync(
      CastingSource value);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<CastingConnectionErrorStatus> DisconnectAsync();

    [MethodImpl]
    public extern void Close();
  }
}
