// Decompiled with JetBrains decompiler
// Type: Windows.UI.Popups.IPopupMenu
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Popups
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PopupMenu))]
  [Guid(1318831836, 34829, 18428, 160, 161, 114, 182, 57, 230, 37, 89)]
  internal interface IPopupMenu
  {
    IVector<IUICommand> Commands { get; }

    IAsyncOperation<IUICommand> ShowAsync(Point invocationPoint);

    [Overload("ShowAsyncWithRect")]
    IAsyncOperation<IUICommand> ShowForSelectionAsync(Rect selection);

    [Overload("ShowAsyncWithRectAndPlacement")]
    IAsyncOperation<IUICommand> ShowForSelectionAsync(
      Rect selection,
      Placement preferredPlacement);
  }
}
