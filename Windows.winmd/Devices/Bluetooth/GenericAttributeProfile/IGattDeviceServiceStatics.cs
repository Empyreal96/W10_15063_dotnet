// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattDeviceServiceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattDeviceService))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(426573858, 64173, 17884, 174, 91, 42, 195, 24, 78, 132, 219)]
  internal interface IGattDeviceServiceStatics
  {
    [Overload("FromIdAsync")]
    [RemoteAsync]
    IAsyncOperation<GattDeviceService> FromIdAsync(string deviceId);

    string GetDeviceSelectorFromUuid(Guid serviceUuid);

    [Deprecated("Use GetDeviceSelectorFromUuid instead of GetDeviceSelectorFromShortId.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    string GetDeviceSelectorFromShortId(ushort serviceShortId);

    [Deprecated("Use BluetoothUuidHelper instead of ConvertShortIdToUuid.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    Guid ConvertShortIdToUuid(ushort shortId);
  }
}
