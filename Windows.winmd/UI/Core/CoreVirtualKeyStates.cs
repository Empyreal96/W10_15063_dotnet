﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.CoreVirtualKeyStates
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum CoreVirtualKeyStates : uint
  {
    None = 0,
    Down = 1,
    Locked = 2,
  }
}
