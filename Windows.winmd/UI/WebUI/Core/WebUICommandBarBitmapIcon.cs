// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.Core.WebUICommandBarBitmapIcon
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI.Core
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IWebUICommandBarBitmapIconFactory), 65536, "Windows.UI.WebUI.Core.WebUICommandBarContract")]
  [ContractVersion(typeof (WebUICommandBarContract), 65536)]
  [Activatable(65536, "Windows.UI.WebUI.Core.WebUICommandBarContract")]
  public sealed class WebUICommandBarBitmapIcon : IWebUICommandBarBitmapIcon, IWebUICommandBarIcon
  {
    [MethodImpl]
    public extern WebUICommandBarBitmapIcon(Uri uri);

    [MethodImpl]
    public extern WebUICommandBarBitmapIcon();

    public extern Uri Uri { [MethodImpl] get; [MethodImpl] set; }
  }
}
