// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Audio.WavFile
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.IO;
using System.Security;

namespace Microsoft.Xna.Framework.Audio
{
  internal class WavFile
  {
    private static byte[] riff = new byte[4]
    {
      (byte) 82,
      (byte) 73,
      (byte) 70,
      (byte) 70
    };
    private static byte[] wave = new byte[4]
    {
      (byte) 87,
      (byte) 65,
      (byte) 86,
      (byte) 69
    };
    private static byte[] fmt = new byte[4]
    {
      (byte) 102,
      (byte) 109,
      (byte) 116,
      (byte) 32
    };
    private static byte[] data = new byte[4]
    {
      (byte) 100,
      (byte) 97,
      (byte) 116,
      (byte) 97
    };
    private static byte[] smpl = new byte[4]
    {
      (byte) 115,
      (byte) 109,
      (byte) 112,
      (byte) 108
    };
    private static byte[] wsmp = new byte[4]
    {
      (byte) 119,
      (byte) 115,
      (byte) 109,
      (byte) 112
    };
    private static int riffId = BitConverter.ToInt32(WavFile.riff, 0);
    private static int wavId = BitConverter.ToInt32(WavFile.wave, 0);
    private static int fmtId = BitConverter.ToInt32(WavFile.fmt, 0);
    private static int smplId = BitConverter.ToInt32(WavFile.smpl, 0);
    private static int wsmpId = BitConverter.ToInt32(WavFile.wsmp, 0);
    private static int dataId = BitConverter.ToInt32(WavFile.data, 0);
    private BinaryReader reader;
    private AudioFormat format;
    private byte[] buffer;
    private WavFile.RiffChunk smplChunk;
    private WavFile.RiffChunk wsmpChunk;
    private LoopRegion loop;

    internal static WavFile Open(Stream stream) => stream != null ? new WavFile(stream) : throw new ArgumentNullException(nameof (stream));

    [SecuritySafeCritical]
    internal WavFile(Stream source)
    {
      this.reader = source != null && source.Length != 0L ? new BinaryReader(source) : throw new ArgumentNullException(nameof (source));
      this.ParseWavHeader();
      long length = this.reader.BaseStream.Length;
      for (long position = this.reader.BaseStream.Position; position < length; position = this.reader.BaseStream.Position)
      {
        try
        {
          this.ReadChunk();
        }
        catch
        {
          break;
        }
      }
      if (this.format == null || this.buffer == null)
        throw new ArgumentException(FrameworkResources.InvalidWaveStream);
      this.ParseLoopRegion();
      this.reader.Close();
    }

    [SecurityCritical]
    private void ParseWavHeader()
    {
      int num1 = AudioHelper.Byteswap(this.reader.ReadInt32());
      int num2 = this.reader.ReadInt32();
      int num3 = AudioHelper.Byteswap(this.reader.ReadInt32());
      int riffId = WavFile.riffId;
      if (num1 != riffId || this.reader.BaseStream.Length - 8L != (long) num2 || num3 != WavFile.wavId)
        throw new InvalidOperationException();
    }

    [SecurityCritical]
    private void ReadChunk()
    {
      if (this.reader.BaseStream.Position % 2L > 0L)
        throw new InvalidOperationException();
      int id = AudioHelper.Byteswap(this.reader.ReadInt32());
      if (id == WavFile.fmtId)
        this.ParseFormat();
      else if (id == WavFile.dataId)
        this.ParseData();
      else if (id == WavFile.smplId)
        this.smplChunk = new WavFile.RiffChunk(id, this.reader.ReadBytes(this.reader.ReadInt32()));
      else if (id == WavFile.wsmpId)
        this.wsmpChunk = new WavFile.RiffChunk(id, this.reader.ReadBytes(this.reader.ReadInt32()));
      else
        this.reader.ReadBytes(this.reader.ReadInt32());
      if (this.reader.BaseStream.Position % 2L <= 0L)
        return;
      int num = (int) this.reader.ReadByte();
    }

    private void ParseFormat()
    {
      int count = this.reader.ReadInt32();
      this.format = count >= 16 ? new AudioFormat(this.reader.ReadBytes(count)) : throw new InvalidOperationException();
      if (this.format.FormatTag != (short) 1 || this.format.Channels != (short) 1 && this.format.Channels != (short) 2 || (this.format.SampleRate < 8000 || this.format.SampleRate > 48000 || this.format.BitsPerSample != (short) 8 && this.format.BitsPerSample != (short) 16) || (int) this.format.BlockAlign != (int) this.format.Channels * (int) this.format.BitsPerSample / 8)
      {
        this.format = (AudioFormat) null;
        throw new InvalidOperationException();
      }
    }

    [SecurityCritical]
    private unsafe void ParseData()
    {
      if (this.format == null)
        throw new InvalidOperationException();
      int num1 = this.reader.ReadInt32();
      if (num1 < (int) this.format.BlockAlign)
        throw new InvalidOperationException();
      BinaryReader reader = this.reader;
      int num2 = num1;
      int count = num2 - num2 % (int) this.format.BlockAlign;
      this.buffer = reader.ReadBytes(count);
      if (this.buffer.Length + this.reader.ReadBytes(num1 % (int) this.format.BlockAlign).Length < num1)
      {
        this.buffer = (byte[]) null;
        throw new InvalidOperationException();
      }
      if (BitConverter.IsLittleEndian || this.format.BitsPerSample != (short) 16)
        return;
      fixed (byte* numPtr = this.buffer)
      {
        for (int index = 0; index < this.buffer.Length / 2; ++index)
          ((short*) numPtr)[index] = AudioHelper.Byteswap(((short*) numPtr)[index]);
      }
    }

    private void ParseLoopRegion()
    {
      this.loop.Start = 0;
      this.loop.Length = this.SampleLength;
      if (this.wsmpChunk != null)
      {
        this.ParseWsmpChunk();
      }
      else
      {
        if (this.smplChunk == null)
          return;
        this.ParseSmplChunk();
      }
    }

    private void ParseWsmpChunk()
    {
      BinaryReader binaryReader = new BinaryReader((Stream) new MemoryStream(this.wsmpChunk.Data));
      binaryReader.ReadBytes(16);
      int num1 = binaryReader.ReadInt32();
      for (int index = 0; index < num1; ++index)
      {
        binaryReader.ReadInt32();
        switch (binaryReader.ReadInt32())
        {
          case 0:
          case 1:
            int num2 = binaryReader.ReadInt32();
            int num3 = binaryReader.ReadInt32();
            if (num2 >= 0 && num2 + num3 <= this.SampleLength)
            {
              this.loop.Start = num2;
              this.loop.Length = num3;
              goto label_6;
            }
            else
              break;
        }
      }
label_6:
      binaryReader.Close();
    }

    private void ParseSmplChunk()
    {
      BinaryReader binaryReader = new BinaryReader((Stream) new MemoryStream(this.smplChunk.Data));
      binaryReader.ReadBytes(28);
      int num1 = binaryReader.ReadInt32();
      binaryReader.ReadInt32();
      for (int index = 0; index < num1; ++index)
      {
        binaryReader.ReadInt32();
        if (binaryReader.ReadInt32() == 0)
        {
          int num2 = binaryReader.ReadInt32();
          int num3 = binaryReader.ReadInt32();
          if (num2 < 0 || num2 >= this.SampleLength || (num2 >= num3 || num3 > this.SampleLength))
            break;
          this.loop.Start = num2;
          this.loop.Length = num3 - num2 + 1;
          break;
        }
        binaryReader.ReadBytes(16);
      }
    }

    internal AudioFormat Format => this.format;

    internal byte[] Data => this.buffer;

    internal int LoopStart => this.loop.Start;

    internal int LoopLength => this.loop.Length;

    internal int SampleLength => this.Data.Length / (int) this.format.BlockAlign;

    internal TimeSpan Duration => this.format.DurationFromSize(this.Data.Length);

    internal class RiffChunk
    {
      public readonly int id;
      public readonly byte[] Data;

      public RiffChunk(int id, byte[] data)
      {
        this.id = id;
        this.Data = data;
      }
    }
  }
}
