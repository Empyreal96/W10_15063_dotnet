// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementDataTypes
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IBluetoothLEAdvertisementDataTypesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public static class BluetoothLEAdvertisementDataTypes
  {
    public static extern byte Flags { [MethodImpl] get; }

    public static extern byte IncompleteService16BitUuids { [MethodImpl] get; }

    public static extern byte CompleteService16BitUuids { [MethodImpl] get; }

    public static extern byte IncompleteService32BitUuids { [MethodImpl] get; }

    public static extern byte CompleteService32BitUuids { [MethodImpl] get; }

    public static extern byte IncompleteService128BitUuids { [MethodImpl] get; }

    public static extern byte CompleteService128BitUuids { [MethodImpl] get; }

    public static extern byte ShortenedLocalName { [MethodImpl] get; }

    public static extern byte CompleteLocalName { [MethodImpl] get; }

    public static extern byte TxPowerLevel { [MethodImpl] get; }

    public static extern byte SlaveConnectionIntervalRange { [MethodImpl] get; }

    public static extern byte ServiceSolicitation16BitUuids { [MethodImpl] get; }

    public static extern byte ServiceSolicitation32BitUuids { [MethodImpl] get; }

    public static extern byte ServiceSolicitation128BitUuids { [MethodImpl] get; }

    public static extern byte ServiceData16BitUuids { [MethodImpl] get; }

    public static extern byte ServiceData32BitUuids { [MethodImpl] get; }

    public static extern byte ServiceData128BitUuids { [MethodImpl] get; }

    public static extern byte PublicTargetAddress { [MethodImpl] get; }

    public static extern byte RandomTargetAddress { [MethodImpl] get; }

    public static extern byte Appearance { [MethodImpl] get; }

    public static extern byte AdvertisingInterval { [MethodImpl] get; }

    public static extern byte ManufacturerSpecificData { [MethodImpl] get; }
  }
}
