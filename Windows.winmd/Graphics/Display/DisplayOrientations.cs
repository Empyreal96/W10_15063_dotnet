// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.DisplayOrientations
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum DisplayOrientations : uint
  {
    None = 0,
    Landscape = 1,
    Portrait = 2,
    LandscapeFlipped = 4,
    PortraitFlipped = 8,
  }
}
