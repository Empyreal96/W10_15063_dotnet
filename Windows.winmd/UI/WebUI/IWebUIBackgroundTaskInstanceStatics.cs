// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.IWebUIBackgroundTaskInstanceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  [ExclusiveTo(typeof (WebUIBackgroundTaskInstance))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2625262225, 6574, 19619, 185, 75, 254, 78, 199, 68, 167, 64)]
  internal interface IWebUIBackgroundTaskInstanceStatics
  {
    IWebUIBackgroundTaskInstance Current { get; }
  }
}
