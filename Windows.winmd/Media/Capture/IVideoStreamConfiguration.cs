// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IVideoStreamConfiguration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Capture
{
  [Guid(3631680111, 17296, 19294, 173, 62, 15, 138, 240, 150, 52, 144)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VideoStreamConfiguration))]
  internal interface IVideoStreamConfiguration
  {
    VideoEncodingProperties InputProperties { get; }

    VideoEncodingProperties OutputProperties { get; }
  }
}
