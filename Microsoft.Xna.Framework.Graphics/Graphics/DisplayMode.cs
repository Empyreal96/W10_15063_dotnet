// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.DisplayMode
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Globalization;

namespace Microsoft.Xna.Framework.Graphics
{
  public class DisplayMode
  {
    internal int _width;
    internal int _height;
    internal SurfaceFormat _format;

    internal DisplayMode(int width, int height, SurfaceFormat format)
    {
      this._width = width;
      this._height = height;
      this._format = format;
    }

    public SurfaceFormat Format => this._format;

    public int Height => this._height;

    public int Width => this._width;

    public float AspectRatio => this._height == 0 || this._width == 0 ? 0.0f : (float) this._width / (float) this._height;

    public Rectangle TitleSafeArea => Viewport.GetTitleSafeArea(0, 0, this._width, this._height);

    public override string ToString() => string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{{Width:{0} Height:{1} Format:{2} AspectRatio:{3}}}", (object) this._width, (object) this._height, (object) this.Format, (object) this.AspectRatio);
  }
}
