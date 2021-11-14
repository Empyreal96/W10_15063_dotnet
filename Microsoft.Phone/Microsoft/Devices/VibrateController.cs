// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.VibrateController
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Devices
{
  public class VibrateController
  {
    internal static readonly TimeSpan MinimumDuration = TimeSpan.FromSeconds(0.0);
    internal static readonly TimeSpan MaximumDuration = TimeSpan.FromSeconds(5.0);
    private static VibrateController instance = new VibrateController();
    private static NativeVibrateController mVibrationInterop = VibrateController.InitNativeVibrateController();

    private VibrateController()
    {
    }

    public static VibrateController Default => VibrateController.instance;

    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "The approved api design uses a singleton.")]
    public void Start(TimeSpan duration)
    {
      if (duration.CompareTo(VibrateController.MaximumDuration) > 0)
        throw new ArgumentOutOfRangeException(nameof (duration), "Duration is more than the max allowed duration");
      if (duration.CompareTo(VibrateController.MinimumDuration) < 0)
        throw new ArgumentOutOfRangeException(nameof (duration), "Duration cannot be negative");
      if (duration.TotalMilliseconds < 1.0 || Environment.DeviceType != DeviceType.Device)
        return;
      VibrateController.mVibrationInterop.Vibrate(duration);
    }

    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "The approved api design uses a singleton.")]
    public void Stop()
    {
      if (Environment.DeviceType != DeviceType.Device)
        return;
      VibrateController.mVibrationInterop.Stop();
    }

    private static NativeVibrateController InitNativeVibrateController() => Environment.DeviceType != DeviceType.Device ? (NativeVibrateController) null : new NativeVibrateController();
  }
}
