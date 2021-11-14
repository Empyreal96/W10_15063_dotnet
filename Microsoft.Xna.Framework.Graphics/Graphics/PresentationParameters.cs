// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.PresentationParameters
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;

namespace Microsoft.Xna.Framework.Graphics
{
  public class PresentationParameters
  {
    internal PresentationParameters.Settings settings;

    public PresentationParameters() => this.IsFullScreen = true;

    public PresentationParameters Clone() => new PresentationParameters()
    {
      settings = this.settings
    };

    public int BackBufferWidth
    {
      get => this.settings.BackBufferWidth;
      set => this.settings.BackBufferWidth = value;
    }

    public int BackBufferHeight
    {
      get => this.settings.BackBufferHeight;
      set => this.settings.BackBufferHeight = value;
    }

    public SurfaceFormat BackBufferFormat
    {
      get => this.settings.BackBufferFormat;
      set => this.settings.BackBufferFormat = value;
    }

    public DepthFormat DepthStencilFormat
    {
      get => this.settings.DepthStencilFormat;
      set => this.settings.DepthStencilFormat = value;
    }

    public int MultiSampleCount
    {
      get => this.settings.MultiSampleCount;
      set => this.settings.MultiSampleCount = value;
    }

    public DisplayOrientation DisplayOrientation
    {
      get => this.settings.DisplayOrientation;
      set => this.settings.DisplayOrientation = value;
    }

    public PresentInterval PresentationInterval
    {
      get => this.settings.PresentationInterval;
      set => this.settings.PresentationInterval = value;
    }

    public RenderTargetUsage RenderTargetUsage
    {
      get => this.settings.RenderTargetUsage;
      set => this.settings.RenderTargetUsage = value;
    }

    public IntPtr DeviceWindowHandle
    {
      get => this.settings.DeviceWindowHandle;
      set => this.settings.DeviceWindowHandle = value;
    }

    public bool IsFullScreen
    {
      get => (uint) this.settings.IsFullScreen > 0U;
      set => this.settings.IsFullScreen = value ? 1 : 0;
    }

    public Rectangle Bounds => new Rectangle(0, 0, this.settings.BackBufferWidth, this.settings.BackBufferHeight);

    internal struct Settings
    {
      public int BackBufferWidth;
      public int BackBufferHeight;
      public SurfaceFormat BackBufferFormat;
      public DepthFormat DepthStencilFormat;
      public int MultiSampleCount;
      public DisplayOrientation DisplayOrientation;
      public PresentInterval PresentationInterval;
      public RenderTargetUsage RenderTargetUsage;
      public IntPtr DeviceWindowHandle;
      public int IsFullScreen;
    }
  }
}
