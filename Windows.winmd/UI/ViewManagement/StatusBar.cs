// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.StatusBar
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Phone;

namespace Windows.UI.ViewManagement
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Static(typeof (IStatusBarStatics), 65536, "Windows.Phone.PhoneContract")]
  public sealed class StatusBar : IStatusBar
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ShowAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction HideAsync();

    public extern double BackgroundOpacity { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<Color> ForegroundColor { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<Color> BackgroundColor { [MethodImpl] get; [MethodImpl] set; }

    public extern StatusBarProgressIndicator ProgressIndicator { [MethodImpl] get; }

    public extern Rect OccludedRect { [MethodImpl] get; }

    public extern event TypedEventHandler<StatusBar, object> Showing;

    public extern event TypedEventHandler<StatusBar, object> Hiding;

    [MethodImpl]
    public static extern StatusBar GetForCurrentView();
  }
}
