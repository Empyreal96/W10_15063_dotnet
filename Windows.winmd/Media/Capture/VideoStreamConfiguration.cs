// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.VideoStreamConfiguration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Capture
{
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VideoStreamConfiguration : IVideoStreamConfiguration
  {
    public extern VideoEncodingProperties InputProperties { [MethodImpl] get; }

    public extern VideoEncodingProperties OutputProperties { [MethodImpl] get; }
  }
}
