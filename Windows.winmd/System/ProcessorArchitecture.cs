// Decompiled with JetBrains decompiler
// Type: Windows.System.ProcessorArchitecture
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ProcessorArchitecture
  {
    X86 = 0,
    Arm = 5,
    X64 = 9,
    Neutral = 11, // 0x0000000B
    Unknown = 65535, // 0x0000FFFF
  }
}
