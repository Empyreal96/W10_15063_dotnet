// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.Core.WebUICommandBarSizeChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI.Core
{
  [ContractVersion(typeof (WebUICommandBarContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WebUICommandBarSizeChangedEventArgs : IWebUICommandBarSizeChangedEventArgs
  {
    public extern Size Size { [MethodImpl] get; }
  }
}
