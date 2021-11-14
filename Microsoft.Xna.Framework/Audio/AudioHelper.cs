// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Audio.AudioHelper
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.IO;

namespace Microsoft.Xna.Framework.Audio
{
  internal static class AudioHelper
  {
    internal const int waveFormatExSize = 18;

    internal static short Byteswap(short value)
    {
      if (!BitConverter.IsLittleEndian)
        value = (short) (((int) value & 65280) >> 8 | ((int) value & (int) byte.MaxValue) << 8);
      return value;
    }

    internal static int Byteswap(int value)
    {
      if (!BitConverter.IsLittleEndian)
        value = value >> 24 | value << 24 | (value & 65280) << 8 | (value & 16711680) >> 8;
      return value;
    }

    public static byte[] MakeFormat(int sampleRate, AudioChannels channels, short bitDepth)
    {
      byte[] buffer = new byte[18];
      BinaryWriter binaryWriter = new BinaryWriter((Stream) new MemoryStream(buffer));
      binaryWriter.Write((short) 1);
      binaryWriter.Write((short) channels);
      binaryWriter.Write(sampleRate);
      binaryWriter.Write(sampleRate * (int) bitDepth / 8 * (int) (short) channels);
      binaryWriter.Write((short) ((int) (short) channels * (int) bitDepth / 8));
      binaryWriter.Write(bitDepth);
      binaryWriter.Write((short) 0);
      binaryWriter.Close();
      return buffer;
    }

    public static byte[] LocalizeFormat(byte[] source)
    {
      BinaryReader binaryReader = new BinaryReader((Stream) new MemoryStream(source));
      byte[] buffer = source;
      if (source.Length < 18)
        buffer = new byte[Math.Max(18, source.Length)];
      BinaryWriter binaryWriter = new BinaryWriter((Stream) new MemoryStream(buffer));
      binaryWriter.Write(AudioHelper.Byteswap(binaryReader.ReadInt16()));
      binaryWriter.Write(AudioHelper.Byteswap(binaryReader.ReadInt16()));
      binaryWriter.Write(AudioHelper.Byteswap(binaryReader.ReadInt32()));
      binaryWriter.Write(AudioHelper.Byteswap(binaryReader.ReadInt32()));
      binaryWriter.Write(AudioHelper.Byteswap(binaryReader.ReadInt16()));
      binaryWriter.Write(AudioHelper.Byteswap(binaryReader.ReadInt16()));
      binaryReader.Close();
      binaryWriter.Close();
      return buffer;
    }

    public static TimeSpan GetSampleDuration(
      int sizeInBytes,
      int sampleRate,
      AudioChannels channels)
    {
      return AudioFormat.Create(sampleRate, channels, (short) 16).DurationFromSize(sizeInBytes);
    }

    public static int GetSampleSizeInBytes(
      TimeSpan duration,
      int sampleRate,
      AudioChannels channels)
    {
      return AudioFormat.Create(sampleRate, channels, (short) 16).SizeFromDuration(duration);
    }
  }
}
