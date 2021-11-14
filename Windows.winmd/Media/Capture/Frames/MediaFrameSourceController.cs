// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.MediaFrameSourceController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Devices;

namespace Windows.Media.Capture.Frames
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772162)]
  public sealed class MediaFrameSourceController : 
    IMediaFrameSourceController,
    IMediaFrameSourceController2
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MediaFrameSourceGetPropertyResult> GetPropertyAsync(
      string propertyId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MediaFrameSourceSetPropertyStatus> SetPropertyAsync(
      string propertyId,
      [Variant] object propertyValue);

    public extern VideoDeviceController VideoDeviceController { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MediaFrameSourceGetPropertyResult> GetPropertyByExtendedIdAsync(
      byte[] extendedPropertyId,
      IReference<uint> maxPropertyValueSize);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MediaFrameSourceSetPropertyStatus> SetPropertyByExtendedIdAsync(
      byte[] extendedPropertyId,
      byte[] propertyValue);
  }
}
