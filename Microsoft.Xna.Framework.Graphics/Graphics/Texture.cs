// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.Texture
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;

namespace Microsoft.Xna.Framework.Graphics
{
  public abstract class Texture : GraphicsResource
  {
    private SurfaceFormat _format;
    private int _levelCount;
    internal bool isActiveRenderTarget;
    internal bool isValidVertexTexture;

    internal Texture()
    {
    }

    public SurfaceFormat Format => this._format;

    public int LevelCount => this._levelCount;

    internal void InitializeDescription(
      GraphicsDevice parent,
      SurfaceFormat format,
      uint levelCount)
    {
      this._parent = parent;
      this._format = format;
      this._levelCount = (int) levelCount;
      this.isValidVertexTexture = parent._profileCapabilities.ValidVertexTextureFormats.Contains(format);
    }

    internal static bool IsPowerOfTwo(int dwNumber)
    {
      if (dwNumber != 0)
      {
        int num = dwNumber;
        if ((num & num - 1) == 0)
          return true;
      }
      return false;
    }

    internal static bool IsCompressed(SurfaceFormat format) => format == SurfaceFormat.Dxt1 || format == SurfaceFormat.Dxt3 || format == SurfaceFormat.Dxt5;

    internal static int GetByteSizeFromFormat(SurfaceFormat format)
    {
      switch (format)
      {
        case SurfaceFormat.Color:
        case SurfaceFormat.NormalizedByte4:
        case SurfaceFormat.Rgba1010102:
        case SurfaceFormat.Rg32:
        case SurfaceFormat.Single:
        case SurfaceFormat.HalfVector2:
          return 4;
        case SurfaceFormat.Bgr565:
        case SurfaceFormat.Bgra5551:
        case SurfaceFormat.Bgra4444:
        case SurfaceFormat.NormalizedByte2:
        case SurfaceFormat.HalfSingle:
          return 2;
        case SurfaceFormat.Dxt1:
        case SurfaceFormat.Rgba64:
        case SurfaceFormat.Vector2:
        case SurfaceFormat.HalfVector4:
        case SurfaceFormat.HdrBlendable:
          return 8;
        case SurfaceFormat.Dxt3:
        case SurfaceFormat.Dxt5:
        case SurfaceFormat.Vector4:
          return 16;
        case SurfaceFormat.Alpha8:
          return 1;
        default:
          throw new InvalidOperationException();
      }
    }

    internal int CompareTo(Texture other)
    {
      uint pComPtr1 = this.pComPtr;
      uint pComPtr2 = other.pComPtr;
      if (pComPtr1 > pComPtr2)
        return -1;
      return pComPtr1 < pComPtr2 ? 1 : 0;
    }
  }
}
