// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.Core.IWebUICommandBarSymbolIconFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI.Core
{
  [ExclusiveTo(typeof (WebUICommandBarSymbolIcon))]
  [ContractVersion(typeof (WebUICommandBarContract), 65536)]
  [Guid(1371413023, 14128, 17054, 182, 34, 20, 226, 183, 191, 106, 7)]
  internal interface IWebUICommandBarSymbolIconFactory
  {
    WebUICommandBarSymbolIcon Create(string symbol);
  }
}
