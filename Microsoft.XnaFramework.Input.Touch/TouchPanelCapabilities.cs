﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.Touch.TouchPanelCapabilities
// Assembly: Microsoft.Xna.Framework.Input.Touch, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 8E9BEFFA-058F-469C-A733-2CE9128BE180
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI3BB0~1.DLL

namespace Microsoft.Xna.Framework.Input.Touch
{
  public struct TouchPanelCapabilities
  {
    public bool IsConnected { get; private set; }

    public int MaximumTouchCount { get; private set; }

    internal static TouchPanelCapabilities GetCaps() => new TouchPanelCapabilities()
    {
      IsConnected = true,
      MaximumTouchCount = 4
    };
  }
}
