// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.Core.WebUICommandBar
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI.Core
{
  [ContractVersion(typeof (WebUICommandBarContract), 65536)]
  [Static(typeof (IWebUICommandBarStatics), 65536, "Windows.UI.WebUI.Core.WebUICommandBarContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WebUICommandBar : IWebUICommandBar
  {
    public extern bool Visible { [MethodImpl] get; [MethodImpl] set; }

    public extern double Opacity { [MethodImpl] get; [MethodImpl] set; }

    public extern Color ForegroundColor { [MethodImpl] get; [MethodImpl] set; }

    public extern Color BackgroundColor { [MethodImpl] get; [MethodImpl] set; }

    public extern WebUICommandBarClosedDisplayMode ClosedDisplayMode { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsOpen { [MethodImpl] get; [MethodImpl] set; }

    public extern Size Size { [MethodImpl] get; }

    public extern IObservableVector<IWebUICommandBarElement> PrimaryCommands { [MethodImpl] get; }

    public extern IObservableVector<IWebUICommandBarElement> SecondaryCommands { [MethodImpl] get; }

    public extern event MenuOpenedEventHandler MenuOpened;

    public extern event MenuClosedEventHandler MenuClosed;

    public extern event SizeChangedEventHandler SizeChanged;

    [MethodImpl]
    public static extern WebUICommandBar GetForCurrentView();
  }
}
