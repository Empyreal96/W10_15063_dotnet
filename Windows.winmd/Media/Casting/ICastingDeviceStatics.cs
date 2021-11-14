// Decompiled with JetBrains decompiler
// Type: Windows.Media.Casting.ICastingDeviceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Casting
{
  [Guid(3889780951, 19731, 16951, 163, 101, 76, 79, 106, 76, 253, 47)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CastingDevice))]
  internal interface ICastingDeviceStatics
  {
    string GetDeviceSelector(CastingPlaybackTypes type);

    [RemoteAsync]
    IAsyncOperation<string> GetDeviceSelectorFromCastingSourceAsync(
      CastingSource castingSource);

    [RemoteAsync]
    IAsyncOperation<CastingDevice> FromIdAsync(string value);

    [RemoteAsync]
    IAsyncOperation<bool> DeviceInfoSupportsCastingAsync(DeviceInformation device);
  }
}
