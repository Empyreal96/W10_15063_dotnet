// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattServiceUuidsStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3534656757, 15637, 20345, 156, 12, 234, 175, 166, 117, 21, 92)]
  [ExclusiveTo(typeof (GattServiceUuids))]
  internal interface IGattServiceUuidsStatics2
  {
    Guid AlertNotification { get; }

    Guid CurrentTime { get; }

    Guid CyclingPower { get; }

    Guid DeviceInformation { get; }

    Guid HumanInterfaceDevice { get; }

    Guid ImmediateAlert { get; }

    Guid LinkLoss { get; }

    Guid LocationAndNavigation { get; }

    Guid NextDstChange { get; }

    Guid PhoneAlertStatus { get; }

    Guid ReferenceTimeUpdate { get; }

    Guid ScanParameters { get; }

    Guid TxPower { get; }
  }
}
