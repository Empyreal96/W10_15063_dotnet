// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Devices.Notification.IVibrationDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Devices.Notification
{
  [Guid(457860501, 53197, 19976, 146, 251, 193, 144, 109, 4, 73, 140)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [ExclusiveTo(typeof (VibrationDevice))]
  internal interface IVibrationDevice
  {
    void Vibrate(TimeSpan duration);

    void Cancel();
  }
}
