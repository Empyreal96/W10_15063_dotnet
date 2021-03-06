// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MediaStreamSourceStartingRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MediaStreamSourceStartingRequest : IMediaStreamSourceStartingRequest
  {
    public extern IReference<TimeSpan> StartPosition { [MethodImpl] get; }

    [MethodImpl]
    public extern MediaStreamSourceStartingRequestDeferral GetDeferral();

    [MethodImpl]
    public extern void SetActualStartPosition(TimeSpan position);
  }
}
