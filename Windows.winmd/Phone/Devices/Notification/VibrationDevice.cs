// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Devices.Notification.VibrationDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Devices.Notification
{
  [Static(typeof (IVibrationDeviceStatics), 65536, "Windows.Phone.PhoneContract")]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class VibrationDevice : IVibrationDevice
  {
    [MethodImpl]
    public extern void Vibrate(TimeSpan duration);

    [MethodImpl]
    public extern void Cancel();

    [MethodImpl]
    public static extern VibrationDevice GetDefault();
  }
}
