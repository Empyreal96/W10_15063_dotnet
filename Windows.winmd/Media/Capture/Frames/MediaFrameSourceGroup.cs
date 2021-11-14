// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.MediaFrameSourceGroup
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  [DualApiPartition(version = 167772162)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMediaFrameSourceGroupStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class MediaFrameSourceGroup : IMediaFrameSourceGroup
  {
    public extern string Id { [MethodImpl] get; }

    public extern string DisplayName { [MethodImpl] get; }

    public extern IVectorView<MediaFrameSourceInfo> SourceInfos { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<MediaFrameSourceGroup>> FindAllAsync();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MediaFrameSourceGroup> FromIdAsync(
      string id);

    [MethodImpl]
    public static extern string GetDeviceSelector();
  }
}
