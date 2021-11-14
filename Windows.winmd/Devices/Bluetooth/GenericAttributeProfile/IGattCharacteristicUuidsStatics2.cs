// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattCharacteristicUuidsStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(408269861, 54382, 18988, 156, 63, 237, 109, 234, 41, 231, 190)]
  [ExclusiveTo(typeof (GattCharacteristicUuids))]
  internal interface IGattCharacteristicUuidsStatics2
  {
    Guid AlertCategoryId { get; }

    Guid AlertCategoryIdBitMask { get; }

    Guid AlertLevel { get; }

    Guid AlertNotificationControlPoint { get; }

    Guid AlertStatus { get; }

    Guid GapAppearance { get; }

    Guid BootKeyboardInputReport { get; }

    Guid BootKeyboardOutputReport { get; }

    Guid BootMouseInputReport { get; }

    Guid CurrentTime { get; }

    Guid CyclingPowerControlPoint { get; }

    Guid CyclingPowerFeature { get; }

    Guid CyclingPowerMeasurement { get; }

    Guid CyclingPowerVector { get; }

    Guid DateTime { get; }

    Guid DayDateTime { get; }

    Guid DayOfWeek { get; }

    Guid GapDeviceName { get; }

    Guid DstOffset { get; }

    Guid ExactTime256 { get; }

    Guid FirmwareRevisionString { get; }

    Guid HardwareRevisionString { get; }

    Guid HidControlPoint { get; }

    Guid HidInformation { get; }

    Guid Ieee1107320601RegulatoryCertificationDataList { get; }

    Guid LnControlPoint { get; }

    Guid LnFeature { get; }

    Guid LocalTimeInformation { get; }

    Guid LocationAndSpeed { get; }

    Guid ManufacturerNameString { get; }

    Guid ModelNumberString { get; }

    Guid Navigation { get; }

    Guid NewAlert { get; }

    Guid GapPeripheralPreferredConnectionParameters { get; }

    Guid GapPeripheralPrivacyFlag { get; }

    Guid PnpId { get; }

    Guid PositionQuality { get; }

    Guid ProtocolMode { get; }

    Guid GapReconnectionAddress { get; }

    Guid ReferenceTimeInformation { get; }

    Guid Report { get; }

    Guid ReportMap { get; }

    Guid RingerControlPoint { get; }

    Guid RingerSetting { get; }

    Guid ScanIntervalWindow { get; }

    Guid ScanRefresh { get; }

    Guid SerialNumberString { get; }

    Guid GattServiceChanged { get; }

    Guid SoftwareRevisionString { get; }

    Guid SupportedNewAlertCategory { get; }

    Guid SupportUnreadAlertCategory { get; }

    Guid SystemId { get; }

    Guid TimeAccuracy { get; }

    Guid TimeSource { get; }

    Guid TimeUpdateControlPoint { get; }

    Guid TimeUpdateState { get; }

    Guid TimeWithDst { get; }

    Guid TimeZone { get; }

    Guid TxPowerLevel { get; }

    Guid UnreadAlertStatus { get; }
  }
}
