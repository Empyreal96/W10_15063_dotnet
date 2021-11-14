// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandDeviceInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Sms;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public sealed class MobileBroadbandDeviceInformation : 
    IMobileBroadbandDeviceInformation,
    IMobileBroadbandDeviceInformation2,
    IMobileBroadbandDeviceInformation3
  {
    public extern NetworkDeviceStatus NetworkDeviceStatus { [MethodImpl] get; }

    public extern string Manufacturer { [MethodImpl] get; }

    public extern string Model { [MethodImpl] get; }

    public extern string FirmwareInformation { [MethodImpl] get; }

    public extern CellularClass CellularClass { [MethodImpl] get; }

    public extern DataClasses DataClasses { [MethodImpl] get; }

    public extern string CustomDataClass { [MethodImpl] get; }

    public extern string MobileEquipmentId { [MethodImpl] get; }

    public extern IVectorView<string> TelephoneNumbers { [MethodImpl] get; }

    public extern string SubscriberId { [MethodImpl] get; }

    public extern string SimIccId { [MethodImpl] get; }

    public extern MobileBroadbandDeviceType DeviceType { [MethodImpl] get; }

    public extern string DeviceId { [MethodImpl] get; }

    public extern MobileBroadbandRadioState CurrentRadioState { [MethodImpl] get; }

    public extern MobileBroadbandPinManager PinManager { [MethodImpl] get; }

    public extern string Revision { [MethodImpl] get; }

    public extern string SerialNumber { [MethodImpl] get; }

    public extern string SimSpn { [MethodImpl] get; }

    public extern string SimPnn { [MethodImpl] get; }

    public extern string SimGid1 { [MethodImpl] get; }
  }
}
