// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementFlags
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum BluetoothLEAdvertisementFlags : uint
  {
    None = 0,
    LimitedDiscoverableMode = 1,
    GeneralDiscoverableMode = 2,
    ClassicNotSupported = 4,
    DualModeControllerCapable = 8,
    DualModeHostCapable = 16, // 0x00000010
  }
}
