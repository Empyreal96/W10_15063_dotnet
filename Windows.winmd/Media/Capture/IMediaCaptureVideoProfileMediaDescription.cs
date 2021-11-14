// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureVideoProfileMediaDescription
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [Guid(2148708335, 46737, 18943, 131, 242, 193, 231, 110, 170, 234, 27)]
  [ExclusiveTo(typeof (MediaCaptureVideoProfileMediaDescription))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaCaptureVideoProfileMediaDescription
  {
    uint Width { get; }

    uint Height { get; }

    double FrameRate { get; }

    bool IsVariablePhotoSequenceSupported { get; }

    bool IsHdrVideoSupported { get; }
  }
}
