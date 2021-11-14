// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.AudioStreamDescriptor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Core
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IAudioStreamDescriptorFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class AudioStreamDescriptor : 
    IAudioStreamDescriptor,
    IMediaStreamDescriptor,
    IAudioStreamDescriptor2
  {
    [MethodImpl]
    public extern AudioStreamDescriptor(AudioEncodingProperties encodingProperties);

    public extern AudioEncodingProperties EncodingProperties { [MethodImpl] get; }

    public extern bool IsSelected { [MethodImpl] get; }

    public extern string Name { [MethodImpl] set; [MethodImpl] get; }

    public extern string Language { [MethodImpl] set; [MethodImpl] get; }

    public extern IReference<uint> LeadingEncoderPadding { [MethodImpl] set; [MethodImpl] get; }

    public extern IReference<uint> TrailingEncoderPadding { [MethodImpl] set; [MethodImpl] get; }
  }
}
