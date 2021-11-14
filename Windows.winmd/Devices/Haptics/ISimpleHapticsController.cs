// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Haptics.ISimpleHapticsController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Haptics
{
  [ExclusiveTo(typeof (SimpleHapticsController))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1029144313, 19694, 4582, 181, 53, 0, 27, 220, 6, 171, 59)]
  internal interface ISimpleHapticsController
  {
    string Id { get; }

    IVectorView<SimpleHapticsControllerFeedback> SupportedFeedback { get; }

    bool IsIntensitySupported { get; }

    bool IsPlayCountSupported { get; }

    bool IsPlayDurationSupported { get; }

    bool IsReplayPauseIntervalSupported { get; }

    void StopFeedback();

    [Overload("SendHapticFeedback")]
    void SendHapticFeedback(SimpleHapticsControllerFeedback feedback);

    [Overload("SendHapticFeedbackWithIntensity")]
    void SendHapticFeedback(SimpleHapticsControllerFeedback feedback, double intensity);

    void SendHapticFeedbackForDuration(
      SimpleHapticsControllerFeedback feedback,
      double intensity,
      TimeSpan playDuration);

    void SendHapticFeedbackForPlayCount(
      SimpleHapticsControllerFeedback feedback,
      double intensity,
      int playCount,
      TimeSpan replayPauseInterval);
  }
}
