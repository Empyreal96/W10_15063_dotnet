// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.AttributeTargets
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;

namespace Windows.Foundation.Metadata
{
  [Flags]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public enum AttributeTargets : uint
  {
    All = 4294967295, // 0xFFFFFFFF
    Delegate = 1,
    Enum = 2,
    Event = 4,
    Field = 8,
    Interface = 16, // 0x00000010
    Method = 64, // 0x00000040
    Parameter = 128, // 0x00000080
    Property = 256, // 0x00000100
    RuntimeClass = 512, // 0x00000200
    Struct = 1024, // 0x00000400
    InterfaceImpl = 2048, // 0x00000800
    ApiContract = 8192, // 0x00002000
  }
}
