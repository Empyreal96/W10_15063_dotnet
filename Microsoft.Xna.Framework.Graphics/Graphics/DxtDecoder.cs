// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.DxtDecoder
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using Microsoft.Xna.Framework.Graphics.PackedVector;
using System;

namespace Microsoft.Xna.Framework.Graphics
{
  internal class DxtDecoder
  {
    private int width;
    private int height;
    private SurfaceFormat format;
    private Color[] colorPalette = new Color[4];
    private byte[] alphaPalette = new byte[8];
    private const int EndianOffset0 = 0;
    private const int EndianOffset1 = 1;

    public DxtDecoder(int width, int height, SurfaceFormat format)
    {
      this.width = ((width | height) & 3) == 0 ? width : throw new ArgumentException();
      this.height = height;
      this.format = format;
    }

    public int PackedDataSize
    {
      get
      {
        int num1 = this.format == SurfaceFormat.Dxt1 ? 8 : 16;
        int num2 = this.width / 4;
        int num3 = this.height / 4;
        int num4 = num2;
        return num1 * num4 * num3;
      }
    }

    public Color[] Decode(byte[] source)
    {
      Color[] result = new Color[this.width * this.height];
      int sourceOffset = 0;
      for (int index1 = 0; index1 < this.height; index1 += 4)
      {
        for (int index2 = 0; index2 < this.width; index2 += 4)
        {
          int resultOffset = index1 * this.width + index2;
          switch (this.format)
          {
            case SurfaceFormat.Dxt1:
              this.DecodeRgbBlock(source, sourceOffset, result, resultOffset, true);
              sourceOffset += 8;
              break;
            case SurfaceFormat.Dxt3:
              this.DecodeRgbBlock(source, sourceOffset + 8, result, resultOffset, false);
              this.DecodeExplicitAlphaBlock(source, sourceOffset, result, resultOffset);
              sourceOffset += 16;
              break;
            case SurfaceFormat.Dxt5:
              this.DecodeRgbBlock(source, sourceOffset + 8, result, resultOffset, false);
              this.DecodeInterpolatedAlphaBlock(source, sourceOffset, result, resultOffset);
              sourceOffset += 16;
              break;
          }
        }
      }
      return result;
    }

    private void DecodeRgbBlock(
      byte[] source,
      int sourceOffset,
      Color[] result,
      int resultOffset,
      bool isDxt1)
    {
      ushort num1 = DxtDecoder.Read16(source, sourceOffset);
      ushort num2 = DxtDecoder.Read16(source, sourceOffset + 2);
      this.colorPalette[0] = new Color(new Bgr565()
      {
        PackedValue = num1
      }.ToVector3());
      this.colorPalette[1] = new Color(new Bgr565()
      {
        PackedValue = num2
      }.ToVector3());
      if ((int) num1 > (int) num2 || !isDxt1)
      {
        this.colorPalette[2] = Color.Lerp(this.colorPalette[0], this.colorPalette[1], 0.3333333f);
        this.colorPalette[3] = Color.Lerp(this.colorPalette[0], this.colorPalette[1], 0.6666667f);
      }
      else
      {
        this.colorPalette[2] = Color.Lerp(this.colorPalette[0], this.colorPalette[1], 0.5f);
        this.colorPalette[3] = Color.Transparent;
      }
      uint num3 = DxtDecoder.Read32(source, sourceOffset + 4);
      for (int index1 = 0; index1 < 4; ++index1)
      {
        for (int index2 = 0; index2 < 4; ++index2)
        {
          uint num4 = num3 & 3U;
          num3 >>= 2;
          result[resultOffset + index1 * this.width + index2] = this.colorPalette[(int) num4];
        }
      }
    }

    private void DecodeExplicitAlphaBlock(
      byte[] source,
      int sourceOffset,
      Color[] result,
      int resultOffset)
    {
      for (int index1 = 0; index1 < 4; ++index1)
      {
        ushort num1 = DxtDecoder.Read16(source, sourceOffset + index1 * 2);
        for (int index2 = 0; index2 < 4; ++index2)
        {
          int num2 = (int) num1 & 15;
          num1 >>= 4;
          result[resultOffset + index1 * this.width + index2].A = (byte) (num2 * (int) byte.MaxValue / 15);
        }
      }
    }

    private void DecodeInterpolatedAlphaBlock(
      byte[] source,
      int sourceOffset,
      Color[] result,
      int resultOffset)
    {
      byte num1 = source[sourceOffset + 0];
      byte num2 = source[sourceOffset + 1];
      this.alphaPalette[0] = num1;
      this.alphaPalette[1] = num2;
      if ((int) num1 > (int) num2)
      {
        this.alphaPalette[2] = (byte) ((6 * (int) num1 + 1 * (int) num2 + 3) / 7);
        this.alphaPalette[3] = (byte) ((5 * (int) num1 + 2 * (int) num2 + 3) / 7);
        this.alphaPalette[4] = (byte) ((4 * (int) num1 + 3 * (int) num2 + 3) / 7);
        this.alphaPalette[5] = (byte) ((3 * (int) num1 + 4 * (int) num2 + 3) / 7);
        this.alphaPalette[6] = (byte) ((2 * (int) num1 + 5 * (int) num2 + 3) / 7);
        this.alphaPalette[7] = (byte) ((1 * (int) num1 + 6 * (int) num2 + 3) / 7);
      }
      else
      {
        this.alphaPalette[2] = (byte) ((4 * (int) num1 + 1 * (int) num2 + 2) / 5);
        this.alphaPalette[3] = (byte) ((3 * (int) num1 + 2 * (int) num2 + 2) / 5);
        this.alphaPalette[4] = (byte) ((2 * (int) num1 + 3 * (int) num2 + 2) / 5);
        this.alphaPalette[5] = (byte) ((1 * (int) num1 + 4 * (int) num2 + 2) / 5);
        this.alphaPalette[6] = (byte) 0;
        this.alphaPalette[7] = byte.MaxValue;
      }
      ulong num3 = DxtDecoder.Read48(source, sourceOffset + 2);
      for (int index1 = 0; index1 < 4; ++index1)
      {
        for (int index2 = 0; index2 < 4; ++index2)
        {
          int index3 = (int) num3 & 7;
          num3 >>= 3;
          result[resultOffset + index1 * this.width + index2].A = this.alphaPalette[index3];
        }
      }
    }

    private static ushort Read16(byte[] source, int offset) => (ushort) ((uint) source[offset + 0] | (uint) source[offset + 1] << 8);

    private static uint Read32(byte[] source, int offset) => (uint) DxtDecoder.Read16(source, offset) | (uint) DxtDecoder.Read16(source, offset + 2) << 16;

    private static ulong Read48(byte[] source, int offset) => (ulong) ((long) DxtDecoder.Read16(source, offset) | (long) DxtDecoder.Read16(source, offset + 2) << 16 | (long) DxtDecoder.Read16(source, offset + 4) << 32);
  }
}
