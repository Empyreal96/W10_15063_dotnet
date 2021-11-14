// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureInitializationSettings5
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Capture.Frames;

namespace Windows.Media.Capture
{
  [Guid(3584222136, 9766, 20116, 183, 179, 83, 8, 160, 246, 75, 26)]
  [ExclusiveTo(typeof (MediaCaptureInitializationSettings))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMediaCaptureInitializationSettings5
  {
    MediaFrameSourceGroup SourceGroup { get; set; }

    MediaCaptureSharingMode SharingMode { get; set; }

    MediaCaptureMemoryPreference MemoryPreference { get; set; }
  }
}
