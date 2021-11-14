// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.CoreTextEditContext
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CoreTextEditContext : ICoreTextEditContext, ICoreTextEditContext2
  {
    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    public extern CoreTextInputScope InputScope { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsReadOnly { [MethodImpl] get; [MethodImpl] set; }

    public extern CoreTextInputPaneDisplayPolicy InputPaneDisplayPolicy { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<CoreTextEditContext, CoreTextTextRequestedEventArgs> TextRequested;

    public extern event TypedEventHandler<CoreTextEditContext, CoreTextSelectionRequestedEventArgs> SelectionRequested;

    public extern event TypedEventHandler<CoreTextEditContext, CoreTextLayoutRequestedEventArgs> LayoutRequested;

    public extern event TypedEventHandler<CoreTextEditContext, CoreTextTextUpdatingEventArgs> TextUpdating;

    public extern event TypedEventHandler<CoreTextEditContext, CoreTextSelectionUpdatingEventArgs> SelectionUpdating;

    public extern event TypedEventHandler<CoreTextEditContext, CoreTextFormatUpdatingEventArgs> FormatUpdating;

    public extern event TypedEventHandler<CoreTextEditContext, CoreTextCompositionStartedEventArgs> CompositionStarted;

    public extern event TypedEventHandler<CoreTextEditContext, CoreTextCompositionCompletedEventArgs> CompositionCompleted;

    public extern event TypedEventHandler<CoreTextEditContext, object> FocusRemoved;

    [MethodImpl]
    public extern void NotifyFocusEnter();

    [MethodImpl]
    public extern void NotifyFocusLeave();

    [MethodImpl]
    public extern void NotifyTextChanged(
      CoreTextRange modifiedRange,
      int newLength,
      CoreTextRange newSelection);

    [MethodImpl]
    public extern void NotifySelectionChanged(CoreTextRange selection);

    [MethodImpl]
    public extern void NotifyLayoutChanged();

    public extern event TypedEventHandler<CoreTextEditContext, object> NotifyFocusLeaveCompleted;
  }
}
