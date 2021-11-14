// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.Core.WebUICommandBarSymbolIcon
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI.Core
{
  [ContractVersion(typeof (WebUICommandBarContract), 65536)]
  [Activatable(typeof (IWebUICommandBarSymbolIconFactory), 65536, "Windows.UI.WebUI.Core.WebUICommandBarContract")]
  [Activatable(65536, "Windows.UI.WebUI.Core.WebUICommandBarContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WebUICommandBarSymbolIcon : IWebUICommandBarSymbolIcon, IWebUICommandBarIcon
  {
    [MethodImpl]
    public extern WebUICommandBarSymbolIcon(string symbol);

    [MethodImpl]
    public extern WebUICommandBarSymbolIcon();

    public extern string Symbol { [MethodImpl] get; [MethodImpl] set; }
  }
}
