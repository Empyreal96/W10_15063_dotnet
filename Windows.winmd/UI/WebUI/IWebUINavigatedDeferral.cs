// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.IWebUINavigatedDeferral
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebUINavigatedDeferral))]
  [Guid(3624149069, 33567, 18146, 180, 50, 58, 252, 226, 17, 249, 98)]
  internal interface IWebUINavigatedDeferral
  {
    void Complete();
  }
}
