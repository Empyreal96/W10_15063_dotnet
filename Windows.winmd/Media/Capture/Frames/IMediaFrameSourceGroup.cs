// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IMediaFrameSourceGroup
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  [ExclusiveTo(typeof (MediaFrameSourceGroup))]
  [Guid(2137021319, 18482, 19295, 174, 61, 65, 47, 170, 179, 125, 52)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMediaFrameSourceGroup
  {
    string Id { get; }

    string DisplayName { get; }

    IVectorView<MediaFrameSourceInfo> SourceInfos { get; }
  }
}
