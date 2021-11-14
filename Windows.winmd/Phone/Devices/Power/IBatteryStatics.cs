// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Devices.Power.IBatteryStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Devices.Power
{
  [ExclusiveTo(typeof (Battery))]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Guid(4210408560, 25449, 4577, 184, 108, 8, 0, 32, 12, 154, 102)]
  internal interface IBatteryStatics
  {
    Battery GetDefault();
  }
}
