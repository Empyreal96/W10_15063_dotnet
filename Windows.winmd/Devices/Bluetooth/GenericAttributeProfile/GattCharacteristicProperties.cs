// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattCharacteristicProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum GattCharacteristicProperties : uint
  {
    None = 0,
    Broadcast = 1,
    Read = 2,
    WriteWithoutResponse = 4,
    Write = 8,
    Notify = 16, // 0x00000010
    Indicate = 32, // 0x00000020
    AuthenticatedSignedWrites = 64, // 0x00000040
    ExtendedProperties = 128, // 0x00000080
    ReliableWrites = 256, // 0x00000100
    WritableAuxiliaries = 512, // 0x00000200
  }
}
