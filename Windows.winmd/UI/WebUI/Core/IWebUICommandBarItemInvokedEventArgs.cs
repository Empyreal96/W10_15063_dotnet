// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.Core.IWebUICommandBarItemInvokedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI.Core
{
  [ContractVersion(typeof (WebUICommandBarContract), 65536)]
  [ExclusiveTo(typeof (WebUICommandBarItemInvokedEventArgs))]
  [Guid(810474461, 59201, 16879, 189, 196, 164, 92, 234, 42, 79, 112)]
  internal interface IWebUICommandBarItemInvokedEventArgs
  {
    bool IsPrimaryCommand { get; }
  }
}
