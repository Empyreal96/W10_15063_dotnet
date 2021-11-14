// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.IWebUINavigatedOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  [ExclusiveTo(typeof (WebUINavigatedOperation))]
  [Guid(2056675080, 33154, 19081, 171, 103, 132, 146, 232, 117, 13, 75)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebUINavigatedOperation
  {
    WebUINavigatedDeferral GetDeferral();
  }
}
