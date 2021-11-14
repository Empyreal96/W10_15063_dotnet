// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadBitrateChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AdaptiveMediaSourceDownloadBitrateChangedEventArgs : 
    IAdaptiveMediaSourceDownloadBitrateChangedEventArgs,
    IAdaptiveMediaSourceDownloadBitrateChangedEventArgs2
  {
    public extern uint OldValue { [MethodImpl] get; }

    public extern uint NewValue { [MethodImpl] get; }

    public extern AdaptiveMediaSourceDownloadBitrateChangedReason Reason { [MethodImpl] get; }
  }
}
