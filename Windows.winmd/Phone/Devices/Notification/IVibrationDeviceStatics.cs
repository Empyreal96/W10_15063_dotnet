// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Devices.Notification.IVibrationDeviceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Devices.Notification
{
  [Guid(858772209, 7273, 19601, 148, 158, 75, 182, 122, 133, 189, 199)]
  [ExclusiveTo(typeof (VibrationDevice))]
  [ContractVersion(typeof (PhoneContract), 65536)]
  internal interface IVibrationDeviceStatics
  {
    VibrationDevice GetDefault();
  }
}
