// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.Core.IWebUICommandBarBitmapIcon
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI.Core
{
  [Guid(2240761669, 2264, 19014, 129, 236, 0, 1, 91, 11, 28, 108)]
  [ContractVersion(typeof (WebUICommandBarContract), 65536)]
  [ExclusiveTo(typeof (WebUICommandBarBitmapIcon))]
  internal interface IWebUICommandBarBitmapIcon : IWebUICommandBarIcon
  {
    Uri Uri { get; set; }
  }
}
