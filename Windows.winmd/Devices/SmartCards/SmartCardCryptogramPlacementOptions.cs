// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardCryptogramPlacementOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [Flags]
  [ContractVersion(typeof (SmartCardEmulatorContract), 131072)]
  public enum SmartCardCryptogramPlacementOptions : uint
  {
    None = 0,
    UnitsAreInNibbles = 1,
    ChainOutput = 2,
  }
}
