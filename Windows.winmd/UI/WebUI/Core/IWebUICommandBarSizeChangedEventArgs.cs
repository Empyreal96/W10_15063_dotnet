// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.Core.IWebUICommandBarSizeChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI.Core
{
  [ContractVersion(typeof (WebUICommandBarContract), 65536)]
  [Guid(4226933494, 12329, 18201, 131, 120, 146, 248, 43, 135, 175, 30)]
  [ExclusiveTo(typeof (WebUICommandBarSizeChangedEventArgs))]
  internal interface IWebUICommandBarSizeChangedEventArgs
  {
    Size Size { get; }
  }
}
