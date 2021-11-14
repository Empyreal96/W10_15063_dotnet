// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.BluetoothServiceCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum BluetoothServiceCapabilities : uint
  {
    None = 0,
    LimitedDiscoverableMode = 1,
    PositioningService = 8,
    NetworkingService = 16, // 0x00000010
    RenderingService = 32, // 0x00000020
    CapturingService = 64, // 0x00000040
    ObjectTransferService = 128, // 0x00000080
    AudioService = 256, // 0x00000100
    TelephoneService = 512, // 0x00000200
    InformationService = 1024, // 0x00000400
  }
}
