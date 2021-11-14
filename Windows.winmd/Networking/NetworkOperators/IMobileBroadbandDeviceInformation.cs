// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandDeviceInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Sms;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MobileBroadbandDeviceInformation))]
  [Guid(3872424296, 58241, 19566, 155, 232, 254, 21, 105, 105, 164, 70)]
  internal interface IMobileBroadbandDeviceInformation
  {
    NetworkDeviceStatus NetworkDeviceStatus { get; }

    string Manufacturer { get; }

    string Model { get; }

    string FirmwareInformation { get; }

    CellularClass CellularClass { get; }

    DataClasses DataClasses { get; }

    string CustomDataClass { get; }

    string MobileEquipmentId { get; }

    IVectorView<string> TelephoneNumbers { get; }

    string SubscriberId { get; }

    string SimIccId { get; }

    MobileBroadbandDeviceType DeviceType { get; }

    string DeviceId { get; }

    MobileBroadbandRadioState CurrentRadioState { get; }
  }
}
