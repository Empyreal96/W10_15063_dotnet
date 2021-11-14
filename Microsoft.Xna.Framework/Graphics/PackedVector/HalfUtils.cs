// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.PackedVector.HalfUtils
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System.Security;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
  internal static class HalfUtils
  {
    private const int cFracBits = 10;
    private const int cExpBits = 5;
    private const int cSignBit = 15;
    private const uint cSignMask = 32768;
    private const uint cFracMask = 1023;
    private const int cExpBias = 15;
    private const uint cRoundBit = 4096;
    private const uint eMax = 16;
    private const int eMin = -14;
    private const uint wMaxNormal = 1207955455;
    private const uint wMinNormal = 947912704;
    private const uint BiasDiffo = 3355443200;
    private const int cFracBitsDiff = 13;

    [SecuritySafeCritical]
    public static unsafe ushort Pack(float value)
    {
      int num1 = (int) *(uint*) &value;
      uint num2 = (uint) (num1 & int.MinValue) >> 16;
      uint num3 = (uint) (num1 & int.MaxValue);
      ushort num4;
      if (num3 > 1207955455U)
        num4 = (ushort) (num2 | (uint) short.MaxValue);
      else if (num3 < 947912704U)
      {
        uint num5 = (uint) ((int) num3 & 8388607 | 8388608);
        int num6 = 113 - (int) (num3 >> 23);
        uint num7 = num6 > 31 ? 0U : num5 >> num6;
        num4 = (ushort) (num2 | (uint) ((int) num7 + 4095 + ((int) (num7 >> 13) & 1)) >> 13);
      }
      else
        num4 = (ushort) (num2 | (uint) ((int) num3 - 939524096 + 4095 + ((int) (num3 >> 13) & 1)) >> 13);
      return num4;
    }

    [SecuritySafeCritical]
    public static unsafe float Unpack(ushort value)
    {
      uint num1;
      if (((int) value & -33792) == 0)
      {
        if (((int) value & 1023) != 0)
        {
          uint num2 = 4294967282;
          uint num3;
          for (num3 = (uint) value & 1023U; ((int) num3 & 1024) == 0; num3 <<= 1)
            --num2;
          uint num4 = num3 & 4294966271U;
          num1 = (uint) (((int) value & 32768) << 16 | (int) num2 + (int) sbyte.MaxValue << 23 | (int) num4 << 13);
        }
        else
          num1 = (uint) (((int) value & 32768) << 16);
      }
      else
        num1 = (uint) (((int) value & 32768) << 16 | ((int) value >> 10 & 31) - 15 + (int) sbyte.MaxValue << 23 | ((int) value & 1023) << 13);
      return *(float*) &num1;
    }
  }
}
