// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GraphicsDeviceInformationComparer
// Assembly: Microsoft.Xna.Framework.Game, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 6EBDB755-3EEE-4715-BDC3-9A6D92805A5E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIBB65~1.DLL

using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Microsoft.Xna.Framework
{
  internal class GraphicsDeviceInformationComparer : IComparer<GraphicsDeviceInformation>
  {
    private GraphicsDeviceManager graphics;

    public GraphicsDeviceInformationComparer(GraphicsDeviceManager graphicsComponent) => this.graphics = graphicsComponent;

    public int Compare(GraphicsDeviceInformation d1, GraphicsDeviceInformation d2)
    {
      if (d1.GraphicsProfile != d2.GraphicsProfile)
        return d1.GraphicsProfile <= d2.GraphicsProfile ? 1 : -1;
      PresentationParameters presentationParameters1 = d1.PresentationParameters;
      PresentationParameters presentationParameters2 = d2.PresentationParameters;
      if (presentationParameters1.IsFullScreen != presentationParameters2.IsFullScreen)
        return this.graphics.IsFullScreen != presentationParameters1.IsFullScreen ? 1 : -1;
      int num1 = this.RankFormat(presentationParameters1.BackBufferFormat);
      int num2 = this.RankFormat(presentationParameters2.BackBufferFormat);
      if (num1 != num2)
        return num1 >= num2 ? 1 : -1;
      if (presentationParameters1.MultiSampleCount != presentationParameters2.MultiSampleCount)
        return presentationParameters1.MultiSampleCount <= presentationParameters2.MultiSampleCount ? 1 : -1;
      float num3 = this.graphics.PreferredBackBufferWidth == 0 || this.graphics.PreferredBackBufferHeight == 0 ? (float) GraphicsDeviceManager.DefaultBackBufferWidth / (float) GraphicsDeviceManager.DefaultBackBufferHeight : (float) this.graphics.PreferredBackBufferWidth / (float) this.graphics.PreferredBackBufferHeight;
      float num4 = (float) presentationParameters1.BackBufferWidth / (float) presentationParameters1.BackBufferHeight;
      double num5 = (double) presentationParameters2.BackBufferWidth / (double) presentationParameters2.BackBufferHeight;
      float num6 = Math.Abs(num4 - num3);
      double num7 = (double) num3;
      float num8 = Math.Abs((float) (num5 - num7));
      if ((double) Math.Abs(num6 - num8) > 0.200000002980232)
        return (double) num6 >= (double) num8 ? 1 : -1;
      int num9;
      int num10;
      if (this.graphics.IsFullScreen)
      {
        if (this.graphics.PreferredBackBufferWidth == 0 || this.graphics.PreferredBackBufferHeight == 0)
        {
          GraphicsAdapter adapter1 = d1.Adapter;
          num9 = adapter1.CurrentDisplayMode.Width * adapter1.CurrentDisplayMode.Height;
          GraphicsAdapter adapter2 = d2.Adapter;
          num10 = adapter2.CurrentDisplayMode.Width * adapter2.CurrentDisplayMode.Height;
        }
        else
          num9 = num10 = this.graphics.PreferredBackBufferWidth * this.graphics.PreferredBackBufferHeight;
      }
      else
        num9 = this.graphics.PreferredBackBufferWidth == 0 || this.graphics.PreferredBackBufferHeight == 0 ? (num10 = GraphicsDeviceManager.DefaultBackBufferWidth * GraphicsDeviceManager.DefaultBackBufferHeight) : (num10 = this.graphics.PreferredBackBufferWidth * this.graphics.PreferredBackBufferHeight);
      int num11 = Math.Abs(presentationParameters1.BackBufferWidth * presentationParameters1.BackBufferHeight - num9);
      int num12 = Math.Abs(presentationParameters2.BackBufferWidth * presentationParameters2.BackBufferHeight - num10);
      if (num11 != num12)
        return num11 >= num12 ? 1 : -1;
      if (d1.Adapter != d2.Adapter)
      {
        if (d1.Adapter.IsDefaultAdapter)
          return -1;
        if (d2.Adapter.IsDefaultAdapter)
          return 1;
      }
      return 0;
    }

    private int RankFormat(SurfaceFormat format)
    {
      if (format == this.graphics.PreferredBackBufferFormat)
        return 0;
      return GraphicsDeviceInformationComparer.SurfaceFormatBitDepth(format) == GraphicsDeviceInformationComparer.SurfaceFormatBitDepth(this.graphics.PreferredBackBufferFormat) ? 1 : int.MaxValue;
    }

    private static int SurfaceFormatBitDepth(SurfaceFormat format)
    {
      switch (format)
      {
        case SurfaceFormat.Color:
        case SurfaceFormat.Rgba1010102:
          return 32;
        case SurfaceFormat.Bgr565:
        case SurfaceFormat.Bgra5551:
        case SurfaceFormat.Bgra4444:
          return 16;
        default:
          return 0;
      }
    }
  }
}
