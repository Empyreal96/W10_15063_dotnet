// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IMediaFrameSourceController2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(4022640596, 64754, 18947, 180, 228, 172, 150, 40, 115, 155, 238)]
  [ExclusiveTo(typeof (MediaFrameSourceController))]
  internal interface IMediaFrameSourceController2
  {
    [RemoteAsync]
    IAsyncOperation<MediaFrameSourceGetPropertyResult> GetPropertyByExtendedIdAsync(
      byte[] extendedPropertyId,
      IReference<uint> maxPropertyValueSize);

    [RemoteAsync]
    IAsyncOperation<MediaFrameSourceSetPropertyStatus> SetPropertyByExtendedIdAsync(
      byte[] extendedPropertyId,
      byte[] propertyValue);
  }
}
