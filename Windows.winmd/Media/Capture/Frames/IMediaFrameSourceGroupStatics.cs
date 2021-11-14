// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IMediaFrameSourceGroupStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaFrameSourceGroup))]
  [Guid(474529733, 17263, 17672, 148, 207, 213, 216, 183, 50, 100, 69)]
  internal interface IMediaFrameSourceGroupStatics
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<MediaFrameSourceGroup>> FindAllAsync();

    [RemoteAsync]
    IAsyncOperation<MediaFrameSourceGroup> FromIdAsync(string id);

    string GetDeviceSelector();
  }
}
