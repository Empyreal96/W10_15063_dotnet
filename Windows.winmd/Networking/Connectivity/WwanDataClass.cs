// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.WwanDataClass
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [Flags]
  [ContractVersion(typeof (WwanContract), 65536)]
  public enum WwanDataClass : uint
  {
    None = 0,
    Gprs = 1,
    Edge = 2,
    Umts = 4,
    Hsdpa = 8,
    Hsupa = 16, // 0x00000010
    LteAdvanced = 32, // 0x00000020
    Cdma1xRtt = 65536, // 0x00010000
    Cdma1xEvdo = 131072, // 0x00020000
    Cdma1xEvdoRevA = 262144, // 0x00040000
    Cdma1xEvdv = 524288, // 0x00080000
    Cdma3xRtt = 1048576, // 0x00100000
    Cdma1xEvdoRevB = 2097152, // 0x00200000
    CdmaUmb = 4194304, // 0x00400000
    Custom = 2147483648, // 0x80000000
  }
}
