// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.Core.HdmiDisplayMode
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display.Core
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 167772163)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HdmiDisplayMode : IHdmiDisplayMode
  {
    public extern uint ResolutionWidthInRawPixels { [MethodImpl] get; }

    public extern uint ResolutionHeightInRawPixels { [MethodImpl] get; }

    public extern double RefreshRate { [MethodImpl] get; }

    public extern bool StereoEnabled { [MethodImpl] get; }

    public extern ushort BitsPerPixel { [MethodImpl] get; }

    [MethodImpl]
    public extern bool IsEqual(HdmiDisplayMode mode);

    public extern HdmiDisplayColorSpace ColorSpace { [MethodImpl] get; }

    public extern HdmiDisplayPixelEncoding PixelEncoding { [MethodImpl] get; }

    public extern bool IsSdrLuminanceSupported { [MethodImpl] get; }

    public extern bool IsSmpte2084Supported { [MethodImpl] get; }

    public extern bool Is2086MetadataSupported { [MethodImpl] get; }
  }
}
