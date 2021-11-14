// Decompiled with JetBrains decompiler
// Type: Windows.Media.ClosedCaptioning.ClosedCaptionProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Media.ClosedCaptioning
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IClosedCaptionPropertiesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class ClosedCaptionProperties
  {
    public static extern ClosedCaptionColor FontColor { [MethodImpl] get; }

    public static extern Color ComputedFontColor { [MethodImpl] get; }

    public static extern ClosedCaptionOpacity FontOpacity { [MethodImpl] get; }

    public static extern ClosedCaptionSize FontSize { [MethodImpl] get; }

    public static extern ClosedCaptionStyle FontStyle { [MethodImpl] get; }

    public static extern ClosedCaptionEdgeEffect FontEffect { [MethodImpl] get; }

    public static extern ClosedCaptionColor BackgroundColor { [MethodImpl] get; }

    public static extern Color ComputedBackgroundColor { [MethodImpl] get; }

    public static extern ClosedCaptionOpacity BackgroundOpacity { [MethodImpl] get; }

    public static extern ClosedCaptionColor RegionColor { [MethodImpl] get; }

    public static extern Color ComputedRegionColor { [MethodImpl] get; }

    public static extern ClosedCaptionOpacity RegionOpacity { [MethodImpl] get; }
  }
}
