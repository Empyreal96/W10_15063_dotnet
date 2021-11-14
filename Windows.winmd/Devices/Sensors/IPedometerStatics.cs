// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IPedometerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (Pedometer))]
  [Guid(2191002159, 16515, 19963, 180, 17, 147, 142, 160, 244, 185, 70)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPedometerStatics
  {
    [RemoteAsync]
    IAsyncOperation<Pedometer> FromIdAsync(string deviceId);

    [RemoteAsync]
    IAsyncOperation<Pedometer> GetDefaultAsync();

    string GetDeviceSelector();

    [RemoteAsync]
    [Overload("GetSystemHistoryAsync")]
    IAsyncOperation<IVectorView<PedometerReading>> GetSystemHistoryAsync(
      DateTime fromTime);

    [Overload("GetSystemHistoryWithDurationAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<PedometerReading>> GetSystemHistoryAsync(
      DateTime fromTime,
      TimeSpan duration);
  }
}
