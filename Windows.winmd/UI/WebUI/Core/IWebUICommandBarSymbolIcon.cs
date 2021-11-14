// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.Core.IWebUICommandBarSymbolIcon
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI.Core
{
  [ExclusiveTo(typeof (WebUICommandBarSymbolIcon))]
  [ContractVersion(typeof (WebUICommandBarContract), 65536)]
  [Guid(3566425207, 64806, 18157, 134, 88, 26, 63, 68, 0, 231, 179)]
  internal interface IWebUICommandBarSymbolIcon : IWebUICommandBarIcon
  {
    string Symbol { get; set; }
  }
}
