// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.IWebUIActivationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(890996413, 17331, 18475, 133, 219, 53, 216, 123, 81, 122, 217)]
  [ExclusiveTo(typeof (WebUIApplication))]
  internal interface IWebUIActivationStatics
  {
    event ActivatedEventHandler Activated;

    event SuspendingEventHandler Suspending;

    event ResumingEventHandler Resuming;

    event NavigatedEventHandler Navigated;
  }
}
