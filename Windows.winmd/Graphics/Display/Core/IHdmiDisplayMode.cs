// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.Core.IHdmiDisplayMode
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display.Core
{
  [ExclusiveTo(typeof (HdmiDisplayMode))]
  [Guid(201774509, 7056, 20305, 153, 129, 239, 90, 28, 13, 223, 102)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IHdmiDisplayMode
  {
    uint ResolutionWidthInRawPixels { get; }

    uint ResolutionHeightInRawPixels { get; }

    double RefreshRate { get; }

    bool StereoEnabled { get; }

    ushort BitsPerPixel { get; }

    bool IsEqual(HdmiDisplayMode mode);

    HdmiDisplayColorSpace ColorSpace { get; }

    HdmiDisplayPixelEncoding PixelEncoding { get; }

    bool IsSdrLuminanceSupported { get; }

    bool IsSmpte2084Supported { get; }

    bool Is2086MetadataSupported { get; }
  }
}
