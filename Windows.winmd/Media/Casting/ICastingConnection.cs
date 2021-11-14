// Decompiled with JetBrains decompiler
// Type: Windows.Media.Casting.ICastingConnection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Casting
{
  [Guid(3449099859, 49905, 17560, 139, 120, 95, 180, 205, 54, 64, 221)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CastingConnection))]
  internal interface ICastingConnection : IClosable
  {
    CastingConnectionState State { get; }

    CastingDevice Device { get; }

    CastingSource Source { get; set; }

    event TypedEventHandler<CastingConnection, object> StateChanged;

    event TypedEventHandler<CastingConnection, CastingConnectionErrorOccurredEventArgs> ErrorOccurred;

    [RemoteAsync]
    IAsyncOperation<CastingConnectionErrorStatus> RequestStartCastingAsync(
      CastingSource value);

    [RemoteAsync]
    IAsyncOperation<CastingConnectionErrorStatus> DisconnectAsync();
  }
}
