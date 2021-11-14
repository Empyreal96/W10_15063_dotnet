// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.Core.IWebUICommandBarIconButton
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI.Core
{
  [ContractVersion(typeof (WebUICommandBarContract), 65536)]
  [Guid(2400962874, 14972, 18498, 160, 207, 175, 246, 234, 48, 133, 134)]
  [ExclusiveTo(typeof (WebUICommandBarIconButton))]
  internal interface IWebUICommandBarIconButton : IWebUICommandBarElement
  {
    bool Enabled { get; set; }

    string Label { get; set; }

    bool IsToggleButton { get; set; }

    bool IsChecked { get; set; }

    IWebUICommandBarIcon Icon { get; set; }

    event TypedEventHandler<WebUICommandBarIconButton, WebUICommandBarItemInvokedEventArgs> ItemInvoked;
  }
}
