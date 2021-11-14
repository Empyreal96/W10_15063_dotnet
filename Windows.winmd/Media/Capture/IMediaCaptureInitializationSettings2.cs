// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureInitializationSettings2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaCaptureInitializationSettings))]
  [Guid(1078855206, 51676, 17385, 174, 228, 230, 191, 27, 87, 180, 76)]
  internal interface IMediaCaptureInitializationSettings2
  {
    MediaCategory MediaCategory { set; get; }

    AudioProcessing AudioProcessing { set; get; }
  }
}
