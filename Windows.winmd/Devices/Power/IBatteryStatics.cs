// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Power.IBatteryStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Power
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Battery))]
  [Guid(2043507382, 40542, 17490, 190, 166, 223, 205, 84, 30, 89, 127)]
  internal interface IBatteryStatics
  {
    Battery AggregateBattery { get; }

    [RemoteAsync]
    IAsyncOperation<Battery> FromIdAsync(string deviceId);

    string GetDeviceSelector();
  }
}
