// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.DisplayInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Display
{
  [Static(typeof (IDisplayInformationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DisplayInformation : 
    IDisplayInformation,
    IDisplayInformation2,
    IDisplayInformation3,
    IDisplayInformation4
  {
    public extern DisplayOrientations CurrentOrientation { [MethodImpl] get; }

    public extern DisplayOrientations NativeOrientation { [MethodImpl] get; }

    public extern event TypedEventHandler<DisplayInformation, object> OrientationChanged;

    public extern ResolutionScale ResolutionScale { [MethodImpl] get; }

    public extern float LogicalDpi { [MethodImpl] get; }

    public extern float RawDpiX { [MethodImpl] get; }

    public extern float RawDpiY { [MethodImpl] get; }

    public extern event TypedEventHandler<DisplayInformation, object> DpiChanged;

    public extern bool StereoEnabled { [MethodImpl] get; }

    public extern event TypedEventHandler<DisplayInformation, object> StereoEnabledChanged;

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStream> GetColorProfileAsync();

    public extern event TypedEventHandler<DisplayInformation, object> ColorProfileChanged;

    public extern double RawPixelsPerViewPixel { [MethodImpl] get; }

    public extern IReference<double> DiagonalSizeInInches { [MethodImpl] get; }

    public extern uint ScreenWidthInRawPixels { [MethodImpl] get; }

    public extern uint ScreenHeightInRawPixels { [MethodImpl] get; }

    [MethodImpl]
    public static extern DisplayInformation GetForCurrentView();

    public static extern DisplayOrientations AutoRotationPreferences { [MethodImpl] get; [MethodImpl] set; }

    public static extern event TypedEventHandler<DisplayInformation, object> DisplayContentsInvalidated;
  }
}
