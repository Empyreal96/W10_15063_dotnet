// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.IWebUIBackgroundTaskInstance
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  [Guid(603008037, 58103, 18241, 188, 156, 57, 69, 149, 222, 36, 220)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IWebUIBackgroundTaskInstance
  {
    bool Succeeded { get; set; }
  }
}
