﻿// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ForceFeedback.ForceFeedbackEffectAxes
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.ForceFeedback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Flags]
  public enum ForceFeedbackEffectAxes : uint
  {
    None = 0,
    X = 1,
    Y = 2,
    Z = 4,
  }
}
