// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.RequiredUINavigationButtons
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum RequiredUINavigationButtons : uint
  {
    None = 0,
    Menu = 1,
    View = 2,
    Accept = 4,
    Cancel = 8,
    Up = 16, // 0x00000010
    Down = 32, // 0x00000020
    Left = 64, // 0x00000040
    Right = 128, // 0x00000080
  }
}
