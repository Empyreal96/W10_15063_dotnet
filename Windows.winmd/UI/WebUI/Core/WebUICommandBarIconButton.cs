// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.Core.WebUICommandBarIconButton
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI.Core
{
  [ContractVersion(typeof (WebUICommandBarContract), 65536)]
  [Activatable(65536, "Windows.UI.WebUI.Core.WebUICommandBarContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WebUICommandBarIconButton : IWebUICommandBarIconButton, IWebUICommandBarElement
  {
    [MethodImpl]
    public extern WebUICommandBarIconButton();

    public extern bool Enabled { [MethodImpl] get; [MethodImpl] set; }

    public extern string Label { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsToggleButton { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsChecked { [MethodImpl] get; [MethodImpl] set; }

    public extern IWebUICommandBarIcon Icon { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<WebUICommandBarIconButton, WebUICommandBarItemInvokedEventArgs> ItemInvoked;
  }
}
