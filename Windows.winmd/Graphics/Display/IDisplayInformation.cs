// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.IDisplayInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Display
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3201372846, 44483, 19913, 174, 101, 133, 31, 77, 125, 71, 153)]
  [ExclusiveTo(typeof (DisplayInformation))]
  internal interface IDisplayInformation
  {
    DisplayOrientations CurrentOrientation { get; }

    DisplayOrientations NativeOrientation { get; }

    event TypedEventHandler<DisplayInformation, object> OrientationChanged;

    ResolutionScale ResolutionScale { get; }

    float LogicalDpi { get; }

    float RawDpiX { get; }

    float RawDpiY { get; }

    event TypedEventHandler<DisplayInformation, object> DpiChanged;

    bool StereoEnabled { get; }

    event TypedEventHandler<DisplayInformation, object> StereoEnabledChanged;

    [RemoteAsync]
    IAsyncOperation<IRandomAccessStream> GetColorProfileAsync();

    event TypedEventHandler<DisplayInformation, object> ColorProfileChanged;
  }
}
