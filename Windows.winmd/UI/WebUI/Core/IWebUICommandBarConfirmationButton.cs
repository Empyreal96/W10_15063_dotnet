// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.Core.IWebUICommandBarConfirmationButton
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI.Core
{
  [ExclusiveTo(typeof (WebUICommandBarConfirmationButton))]
  [ContractVersion(typeof (WebUICommandBarContract), 65536)]
  [Guid(2263319114, 58325, 20150, 178, 255, 143, 1, 138, 23, 33, 5)]
  internal interface IWebUICommandBarConfirmationButton : IWebUICommandBarElement
  {
    string Text { get; set; }

    event TypedEventHandler<WebUICommandBarConfirmationButton, WebUICommandBarItemInvokedEventArgs> ItemInvoked;
  }
}
