﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ElementHighContrastAdjustment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum ElementHighContrastAdjustment : uint
  {
    None = 0,
    Application = 2147483648, // 0x80000000
    Auto = 4294967295, // 0xFFFFFFFF
  }
}
