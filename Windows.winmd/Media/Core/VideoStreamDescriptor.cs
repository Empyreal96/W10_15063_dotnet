// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.VideoStreamDescriptor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IVideoStreamDescriptorFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class VideoStreamDescriptor : IVideoStreamDescriptor, IMediaStreamDescriptor
  {
    [MethodImpl]
    public extern VideoStreamDescriptor(VideoEncodingProperties encodingProperties);

    public extern VideoEncodingProperties EncodingProperties { [MethodImpl] get; }

    public extern bool IsSelected { [MethodImpl] get; }

    public extern string Name { [MethodImpl] set; [MethodImpl] get; }

    public extern string Language { [MethodImpl] set; [MethodImpl] get; }
  }
}
