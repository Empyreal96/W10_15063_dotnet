// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.TextSetOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum TextSetOptions : uint
  {
    None = 0,
    UnicodeBidi = 1,
    Unlink = 8,
    Unhide = 16, // 0x00000010
    CheckTextLimit = 32, // 0x00000020
    FormatRtf = 8192, // 0x00002000
    ApplyRtfDocumentDefaults = 16384, // 0x00004000
  }
}
