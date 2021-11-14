// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.ICoreTextEditContext
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3211135151, 16449, 18371, 178, 99, 169, 24, 235, 94, 174, 242)]
  [ExclusiveTo(typeof (CoreTextEditContext))]
  internal interface ICoreTextEditContext
  {
    string Name { get; set; }

    CoreTextInputScope InputScope { get; set; }

    bool IsReadOnly { get; set; }

    CoreTextInputPaneDisplayPolicy InputPaneDisplayPolicy { get; set; }

    event TypedEventHandler<CoreTextEditContext, CoreTextTextRequestedEventArgs> TextRequested;

    event TypedEventHandler<CoreTextEditContext, CoreTextSelectionRequestedEventArgs> SelectionRequested;

    event TypedEventHandler<CoreTextEditContext, CoreTextLayoutRequestedEventArgs> LayoutRequested;

    event TypedEventHandler<CoreTextEditContext, CoreTextTextUpdatingEventArgs> TextUpdating;

    event TypedEventHandler<CoreTextEditContext, CoreTextSelectionUpdatingEventArgs> SelectionUpdating;

    event TypedEventHandler<CoreTextEditContext, CoreTextFormatUpdatingEventArgs> FormatUpdating;

    event TypedEventHandler<CoreTextEditContext, CoreTextCompositionStartedEventArgs> CompositionStarted;

    event TypedEventHandler<CoreTextEditContext, CoreTextCompositionCompletedEventArgs> CompositionCompleted;

    event TypedEventHandler<CoreTextEditContext, object> FocusRemoved;

    void NotifyFocusEnter();

    void NotifyFocusLeave();

    void NotifyTextChanged(CoreTextRange modifiedRange, int newLength, CoreTextRange newSelection);

    void NotifySelectionChanged(CoreTextRange selection);

    void NotifyLayoutChanged();
  }
}
