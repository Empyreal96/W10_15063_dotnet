// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IStatusBar
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Phone;

namespace Windows.UI.ViewManagement
{
  [ExclusiveTo(typeof (StatusBar))]
  [Guid(268223935, 39120, 18532, 177, 232, 179, 244, 2, 11, 232, 180)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  internal interface IStatusBar
  {
    [RemoteAsync]
    IAsyncAction ShowAsync();

    [RemoteAsync]
    IAsyncAction HideAsync();

    double BackgroundOpacity { get; set; }

    IReference<Color> ForegroundColor { get; set; }

    IReference<Color> BackgroundColor { get; set; }

    StatusBarProgressIndicator ProgressIndicator { get; }

    Rect OccludedRect { get; }

    event TypedEventHandler<StatusBar, object> Showing;

    event TypedEventHandler<StatusBar, object> Hiding;
  }
}
