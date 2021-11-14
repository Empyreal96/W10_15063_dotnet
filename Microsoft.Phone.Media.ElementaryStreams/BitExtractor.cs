// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Media.ElementaryStreams.BitExtractor
// Assembly: Microsoft.Phone.Media.ElementaryStreams, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: C4AB28B9-B09C-47FC-B326-6B155141A87A
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIFD1A~1.DLL

using System;

namespace Microsoft.Phone.Media.ElementaryStreams
{
  public class BitExtractor
  {
    public BitExtractor()
    {
    }

    public BitExtractor(byte[] buffer) => this.Initialize(buffer, 0);

    public BitExtractor(byte[] buffer, int offset) => this.Initialize(buffer, offset);

    public void Initialize(byte[] buffer, int offset)
    {
      this.Buffer = buffer;
      this.Offset = offset;
      this.BitOffset = 0;
    }

    public bool ReadFlag() => (uint) this.ReadBits(1) > 0U;

    public void SkipBits(int n)
    {
      if (n == 0)
        return;
      if (n > this.RemainingBits)
        throw new BitExtractorException(string.Format("Attempted to skip {0} bit(s) with only {1} left", (object) n, (object) this.RemainingBits));
      this.BitOffset += n;
      this.Offset += this.BitOffset / 8;
      this.BitOffset %= 8;
    }

    public int ReadBits(int n) => n <= 31 ? (int) this.ReadBitsULong(n) : throw new ArgumentOutOfRangeException(nameof (n));

    public uint ReadUBits(int n) => n <= 32 ? (uint) this.ReadBitsULong(n) : throw new ArgumentOutOfRangeException(nameof (n));

    public ulong ReadBitsULong(int n)
    {
      if (n > 64)
        throw new ArgumentOutOfRangeException(nameof (n));
      if (n > this.RemainingBits)
        throw new BitExtractorException(string.Format("Attempted to read {0} bit(s) with only {1} left", (object) n, (object) this.RemainingBits));
      if (this.BitOffset == 0 && n == 8)
        return (ulong) this.Buffer[this.Offset++];
      ulong num1 = 0;
      for (int index = 8; index <= n; index += 8)
        num1 |= (ulong) this.ReadByte() << n - index;
      int num2 = n % 8;
      if (num2 > 0)
      {
        int num3 = this.BitOffset + num2;
        byte num4 = (byte) ((int) byte.MaxValue >> 8 - num2);
        if (num3 > 8)
        {
          num1 |= (ulong) ((uint) ((int) this.Buffer[this.Offset++] << num3 - 8 | (int) this.Buffer[this.Offset] >> 16 - num3) & (uint) num4);
        }
        else
        {
          num1 |= (ulong) ((uint) this.Buffer[this.Offset] >> 8 - num3 & (uint) num4);
          if (num3 == 8)
            ++this.Offset;
        }
        this.BitOffset = num3 & 7;
      }
      return num1;
    }

    public byte ReadByte() => this.BitOffset == 0 ? this.Buffer[this.Offset++] : (byte) ((int) this.Buffer[this.Offset++] << this.BitOffset | (int) this.Buffer[this.Offset] >> 8 - this.BitOffset);

    public int ReadUnsignedExponentialGolomb()
    {
      int n = 0;
      while (this.ReadBits(1) == 0)
        ++n;
      return n != 0 ? (1 << n) - 1 + this.ReadBits(n) : 0;
    }

    public int ReadSignedExponentialGolomb()
    {
      int num = this.ReadUnsignedExponentialGolomb();
      return (num & 1) != 0 ? (num + 1) / 2 : -num / 2;
    }

    public int CurrentBitOffset => this.Offset * 8 + this.BitOffset;

    public int RemainingBits => (this.Buffer.Length - this.Offset) * 8 - this.BitOffset;

    public int RemainingBytes => this.Buffer.Length - this.Offset - (this.BitOffset + 7) / 8;

    public byte[] Buffer { get; set; }

    public int Offset { get; set; }

    public int BitOffset { get; set; }
  }
}
