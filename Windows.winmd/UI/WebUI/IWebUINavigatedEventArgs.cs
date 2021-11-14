// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.IWebUINavigatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2807579064, 9369, 16432, 166, 157, 21, 210, 217, 207, 229, 36)]
  public interface IWebUINavigatedEventArgs
  {
    WebUINavigatedOperation NavigatedOperation { get; }
  }
}
