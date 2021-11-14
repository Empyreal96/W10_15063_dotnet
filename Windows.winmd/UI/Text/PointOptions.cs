// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.PointOptions
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
  public enum PointOptions : uint
  {
    None = 0,
    IncludeInset = 1,
    Start = 32, // 0x00000020
    ClientCoordinates = 256, // 0x00000100
    AllowOffClient = 512, // 0x00000200
    Transform = 1024, // 0x00000400
    NoHorizontalScroll = 65536, // 0x00010000
    NoVerticalScroll = 262144, // 0x00040000
  }
}
