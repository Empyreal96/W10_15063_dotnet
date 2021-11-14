// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.PosPrinterColorCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum PosPrinterColorCapabilities : uint
  {
    None = 0,
    Primary = 1,
    Custom1 = 2,
    Custom2 = 4,
    Custom3 = 8,
    Custom4 = 16, // 0x00000010
    Custom5 = 32, // 0x00000020
    Custom6 = 64, // 0x00000040
    Cyan = 128, // 0x00000080
    Magenta = 256, // 0x00000100
    Yellow = 512, // 0x00000200
    Full = 1024, // 0x00000400
  }
}
