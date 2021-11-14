// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.MediaCaptureVideoProfile
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class MediaCaptureVideoProfile : IMediaCaptureVideoProfile
  {
    public extern string Id { [MethodImpl] get; }

    public extern string VideoDeviceId { [MethodImpl] get; }

    public extern IVectorView<MediaCaptureVideoProfileMediaDescription> SupportedPreviewMediaDescription { [MethodImpl] get; }

    public extern IVectorView<MediaCaptureVideoProfileMediaDescription> SupportedRecordMediaDescription { [MethodImpl] get; }

    public extern IVectorView<MediaCaptureVideoProfileMediaDescription> SupportedPhotoMediaDescription { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<MediaCaptureVideoProfile> GetConcurrency();
  }
}
