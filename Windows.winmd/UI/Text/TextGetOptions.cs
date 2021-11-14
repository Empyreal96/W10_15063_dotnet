// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.TextGetOptions
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
  public enum TextGetOptions : uint
  {
    None = 0,
    AdjustCrlf = 1,
    UseCrlf = 2,
    UseObjectText = 4,
    AllowFinalEop = 8,
    NoHidden = 32, // 0x00000020
    IncludeNumbering = 64, // 0x00000040
    FormatRtf = 8192, // 0x00002000
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] UseLf = 16777216, // 0x01000000
  }
}
