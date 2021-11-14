// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.Core.IWebUICommandBar
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI.Core
{
  [ExclusiveTo(typeof (WebUICommandBar))]
  [Guid(2767978518, 56293, 16813, 141, 123, 20, 105, 139, 214, 145, 29)]
  [ContractVersion(typeof (WebUICommandBarContract), 65536)]
  internal interface IWebUICommandBar
  {
    bool Visible { get; set; }

    double Opacity { get; set; }

    Color ForegroundColor { get; set; }

    Color BackgroundColor { get; set; }

    WebUICommandBarClosedDisplayMode ClosedDisplayMode { get; set; }

    bool IsOpen { get; set; }

    Size Size { get; }

    IObservableVector<IWebUICommandBarElement> PrimaryCommands { get; }

    IObservableVector<IWebUICommandBarElement> SecondaryCommands { get; }

    event MenuOpenedEventHandler MenuOpened;

    event MenuClosedEventHandler MenuClosed;

    event SizeChangedEventHandler SizeChanged;
  }
}
