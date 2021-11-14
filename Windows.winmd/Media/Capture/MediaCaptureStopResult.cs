// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.MediaCaptureStopResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [DualApiPartition(version = 167772162)]
  [Threading(ThreadingModel.MTA)]
  [GCPressure(amount = GCPressureAmount.High)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class MediaCaptureStopResult : IMediaCaptureStopResult, IClosable
  {
    public extern VideoFrame LastFrame { [MethodImpl] get; }

    public extern TimeSpan RecordDuration { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();
  }
}
