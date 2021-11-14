// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Haptics.SimpleHapticsController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Haptics
{
  [DualApiPartition(version = 167772163)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class SimpleHapticsController : ISimpleHapticsController
  {
    public extern string Id { [MethodImpl] get; }

    public extern IVectorView<SimpleHapticsControllerFeedback> SupportedFeedback { [MethodImpl] get; }

    public extern bool IsIntensitySupported { [MethodImpl] get; }

    public extern bool IsPlayCountSupported { [MethodImpl] get; }

    public extern bool IsPlayDurationSupported { [MethodImpl] get; }

    public extern bool IsReplayPauseIntervalSupported { [MethodImpl] get; }

    [MethodImpl]
    public extern void StopFeedback();

    [Overload("SendHapticFeedback")]
    [MethodImpl]
    public extern void SendHapticFeedback(SimpleHapticsControllerFeedback feedback);

    [Overload("SendHapticFeedbackWithIntensity")]
    [MethodImpl]
    public extern void SendHapticFeedback(
      SimpleHapticsControllerFeedback feedback,
      double intensity);

    [MethodImpl]
    public extern void SendHapticFeedbackForDuration(
      SimpleHapticsControllerFeedback feedback,
      double intensity,
      TimeSpan playDuration);

    [MethodImpl]
    public extern void SendHapticFeedbackForPlayCount(
      SimpleHapticsControllerFeedback feedback,
      double intensity,
      int playCount,
      TimeSpan replayPauseInterval);
  }
}
