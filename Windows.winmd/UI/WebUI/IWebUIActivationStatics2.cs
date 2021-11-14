// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.IWebUIActivationStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  [Guid(3370682006, 19832, 19108, 143, 6, 42, 158, 173, 198, 196, 10)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (WebUIApplication))]
  internal interface IWebUIActivationStatics2
  {
    event LeavingBackgroundEventHandler LeavingBackground;

    event EnteredBackgroundEventHandler EnteredBackground;

    void EnablePrelaunch(bool value);
  }
}
