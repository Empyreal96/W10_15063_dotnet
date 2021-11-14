// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.WebUIApplication
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  [MarshalingBehavior(MarshalingType.Standard)]
  [Static(typeof (IWebUIActivationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IWebUIActivationStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class WebUIApplication
  {
    public static extern event LeavingBackgroundEventHandler LeavingBackground;

    public static extern event EnteredBackgroundEventHandler EnteredBackground;

    [MethodImpl]
    public static extern void EnablePrelaunch(bool value);

    public static extern event ActivatedEventHandler Activated;

    public static extern event SuspendingEventHandler Suspending;

    public static extern event ResumingEventHandler Resuming;

    public static extern event NavigatedEventHandler Navigated;
  }
}
