// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.InputPane
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [Static(typeof (IInputPaneStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772162)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Muse(Version = 100794368)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class InputPane : IInputPane, IInputPane2, IInputPaneControl
  {
    public extern event TypedEventHandler<InputPane, InputPaneVisibilityEventArgs> Showing;

    public extern event TypedEventHandler<InputPane, InputPaneVisibilityEventArgs> Hiding;

    public extern Rect OccludedRect { [MethodImpl] get; }

    [MethodImpl]
    public extern bool TryShow();

    [MethodImpl]
    public extern bool TryHide();

    public extern bool Visible { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public static extern InputPane GetForCurrentView();
  }
}
