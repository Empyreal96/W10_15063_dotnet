// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.PreparingDeviceSettingsEventArgs
// Assembly: Microsoft.Xna.Framework.Game, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 6EBDB755-3EEE-4715-BDC3-9A6D92805A5E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIBB65~1.DLL

using System;

namespace Microsoft.Xna.Framework
{
  public class PreparingDeviceSettingsEventArgs : EventArgs
  {
    private GraphicsDeviceInformation graphicsDeviceInformation;

    public GraphicsDeviceInformation GraphicsDeviceInformation => this.graphicsDeviceInformation;

    public PreparingDeviceSettingsEventArgs(
      GraphicsDeviceInformation graphicsDeviceInformation)
    {
      this.graphicsDeviceInformation = graphicsDeviceInformation;
    }
  }
}
