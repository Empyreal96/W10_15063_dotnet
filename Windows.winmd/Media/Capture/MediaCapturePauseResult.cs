// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.MediaCapturePauseResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [GCPressure(amount = GCPressureAmount.High)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Threading(ThreadingModel.MTA)]
  [DualApiPartition(version = 167772162)]
  public sealed class MediaCapturePauseResult : IMediaCapturePauseResult, IClosable
  {
    public extern VideoFrame LastFrame { [MethodImpl] get; }

    public extern TimeSpan RecordDuration { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();
  }
}
