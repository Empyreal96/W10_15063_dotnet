// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Audio.AudioFormat
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.IO;

namespace Microsoft.Xna.Framework.Audio
{
  internal class AudioFormat
  {
    public readonly byte[] RawBuffer;
    public readonly short FormatTag;
    public readonly short Channels;
    public readonly int SampleRate;
    public readonly int AvgBytesPerSec;
    public readonly short BlockAlign;
    public readonly short BitsPerSample;

    public static AudioFormat Create(
      int sampleRate,
      AudioChannels channels,
      short bitDepth)
    {
      return new AudioFormat(AudioHelper.MakeFormat(sampleRate, channels, bitDepth));
    }

    public AudioFormat(byte[] buffer)
    {
      BinaryReader binaryReader = new BinaryReader((Stream) new MemoryStream(buffer));
      this.FormatTag = binaryReader.ReadInt16();
      this.Channels = binaryReader.ReadInt16();
      this.SampleRate = binaryReader.ReadInt32();
      this.AvgBytesPerSec = binaryReader.ReadInt32();
      this.BlockAlign = binaryReader.ReadInt16();
      this.BitsPerSample = binaryReader.ReadInt16();
      binaryReader.Close();
      this.RawBuffer = AudioHelper.LocalizeFormat(buffer);
    }

    public bool IsAligned(int value) => value % (int) this.BlockAlign == 0;

    public TimeSpan DurationFromSize(int sizeInBytes) => TimeSpan.FromMilliseconds((double) (sizeInBytes / (int) this.BlockAlign) * 1000.0 / (double) this.SampleRate);

    public int SizeFromDuration(TimeSpan duration)
    {
      int num = checked ((int) unchecked (duration.TotalMilliseconds * (double) this.SampleRate / 1000.0));
      return checked (num + unchecked (num % (int) this.Channels) * (int) this.BlockAlign);
    }
  }
}
