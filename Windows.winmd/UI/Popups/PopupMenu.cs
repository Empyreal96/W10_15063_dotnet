// Decompiled with JetBrains decompiler
// Type: Windows.UI.Popups.PopupMenu
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Popups
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Muse(Version = 100794368)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class PopupMenu : IPopupMenu
  {
    [MethodImpl]
    public extern PopupMenu();

    public extern IVector<IUICommand> Commands { [MethodImpl] get; }

    [MethodImpl]
    public extern IAsyncOperation<IUICommand> ShowAsync(
      Point invocationPoint);

    [Overload("ShowAsyncWithRect")]
    [MethodImpl]
    public extern IAsyncOperation<IUICommand> ShowForSelectionAsync(
      Rect selection);

    [Overload("ShowAsyncWithRectAndPlacement")]
    [MethodImpl]
    public extern IAsyncOperation<IUICommand> ShowForSelectionAsync(
      Rect selection,
      Placement preferredPlacement);
  }
}
