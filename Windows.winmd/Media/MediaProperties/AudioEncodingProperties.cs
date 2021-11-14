// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.AudioEncodingProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAudioEncodingPropertiesStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IAudioEncodingPropertiesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  public sealed class AudioEncodingProperties : 
    IAudioEncodingProperties,
    IMediaEncodingProperties,
    IAudioEncodingPropertiesWithFormatUserData,
    IAudioEncodingProperties2
  {
    [MethodImpl]
    public extern AudioEncodingProperties();

    public extern uint Bitrate { [MethodImpl] set; [MethodImpl] get; }

    public extern uint ChannelCount { [MethodImpl] set; [MethodImpl] get; }

    public extern uint SampleRate { [MethodImpl] set; [MethodImpl] get; }

    public extern uint BitsPerSample { [MethodImpl] set; [MethodImpl] get; }

    public extern MediaPropertySet Properties { [MethodImpl] get; }

    public extern string Type { [MethodImpl] get; }

    public extern string Subtype { [MethodImpl] set; [MethodImpl] get; }

    [MethodImpl]
    public extern void SetFormatUserData(byte[] value);

    [MethodImpl]
    public extern void GetFormatUserData(out byte[] value);

    public extern bool IsSpatial { [MethodImpl] get; }

    [MethodImpl]
    public static extern AudioEncodingProperties CreateAlac(
      uint sampleRate,
      uint channelCount,
      uint bitsPerSample);

    [MethodImpl]
    public static extern AudioEncodingProperties CreateFlac(
      uint sampleRate,
      uint channelCount,
      uint bitsPerSample);

    [MethodImpl]
    public static extern AudioEncodingProperties CreateAac(
      uint sampleRate,
      uint channelCount,
      uint bitrate);

    [MethodImpl]
    public static extern AudioEncodingProperties CreateAacAdts(
      uint sampleRate,
      uint channelCount,
      uint bitrate);

    [MethodImpl]
    public static extern AudioEncodingProperties CreateMp3(
      uint sampleRate,
      uint channelCount,
      uint bitrate);

    [MethodImpl]
    public static extern AudioEncodingProperties CreatePcm(
      uint sampleRate,
      uint channelCount,
      uint bitsPerSample);

    [MethodImpl]
    public static extern AudioEncodingProperties CreateWma(
      uint sampleRate,
      uint channelCount,
      uint bitrate);
  }
}
