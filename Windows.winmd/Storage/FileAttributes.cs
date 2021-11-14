// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileAttributes
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum FileAttributes : uint
  {
    Normal = 0,
    ReadOnly = 1,
    Directory = 16, // 0x00000010
    Archive = 32, // 0x00000020
    Temporary = 256, // 0x00000100
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] LocallyIncomplete = 512, // 0x00000200
  }
}
