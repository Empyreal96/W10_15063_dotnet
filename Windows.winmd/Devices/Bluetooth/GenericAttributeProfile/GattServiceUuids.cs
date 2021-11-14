// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattServiceUuids
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IGattServiceUuidsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IGattServiceUuidsStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class GattServiceUuids
  {
    public static extern Guid AlertNotification { [MethodImpl] get; }

    public static extern Guid CurrentTime { [MethodImpl] get; }

    public static extern Guid CyclingPower { [MethodImpl] get; }

    public static extern Guid DeviceInformation { [MethodImpl] get; }

    public static extern Guid HumanInterfaceDevice { [MethodImpl] get; }

    public static extern Guid ImmediateAlert { [MethodImpl] get; }

    public static extern Guid LinkLoss { [MethodImpl] get; }

    public static extern Guid LocationAndNavigation { [MethodImpl] get; }

    public static extern Guid NextDstChange { [MethodImpl] get; }

    public static extern Guid PhoneAlertStatus { [MethodImpl] get; }

    public static extern Guid ReferenceTimeUpdate { [MethodImpl] get; }

    public static extern Guid ScanParameters { [MethodImpl] get; }

    public static extern Guid TxPower { [MethodImpl] get; }

    public static extern Guid Battery { [MethodImpl] get; }

    public static extern Guid BloodPressure { [MethodImpl] get; }

    public static extern Guid CyclingSpeedAndCadence { [MethodImpl] get; }

    public static extern Guid GenericAccess { [MethodImpl] get; }

    public static extern Guid GenericAttribute { [MethodImpl] get; }

    public static extern Guid Glucose { [MethodImpl] get; }

    public static extern Guid HealthThermometer { [MethodImpl] get; }

    public static extern Guid HeartRate { [MethodImpl] get; }

    public static extern Guid RunningSpeedAndCadence { [MethodImpl] get; }
  }
}
