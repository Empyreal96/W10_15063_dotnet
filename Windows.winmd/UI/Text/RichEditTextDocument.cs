// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.RichEditTextDocument
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Text
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class RichEditTextDocument : ITextDocument, ITextDocument2
  {
    public extern CaretType CaretType { [MethodImpl] get; [MethodImpl] set; }

    public extern float DefaultTabStop { [MethodImpl] get; [MethodImpl] set; }

    public extern ITextSelection Selection { [MethodImpl] get; }

    public extern uint UndoLimit { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern bool CanCopy();

    [MethodImpl]
    public extern bool CanPaste();

    [MethodImpl]
    public extern bool CanRedo();

    [MethodImpl]
    public extern bool CanUndo();

    [MethodImpl]
    public extern int ApplyDisplayUpdates();

    [MethodImpl]
    public extern int BatchDisplayUpdates();

    [MethodImpl]
    public extern void BeginUndoGroup();

    [MethodImpl]
    public extern void EndUndoGroup();

    [MethodImpl]
    public extern ITextCharacterFormat GetDefaultCharacterFormat();

    [MethodImpl]
    public extern ITextParagraphFormat GetDefaultParagraphFormat();

    [MethodImpl]
    public extern ITextRange GetRange(int startPosition, int endPosition);

    [MethodImpl]
    public extern ITextRange GetRangeFromPoint(Point point, PointOptions options);

    [MethodImpl]
    public extern void GetText(TextGetOptions options, out string value);

    [MethodImpl]
    public extern void LoadFromStream(TextSetOptions options, IRandomAccessStream value);

    [MethodImpl]
    public extern void Redo();

    [MethodImpl]
    public extern void SaveToStream(TextGetOptions options, IRandomAccessStream value);

    [MethodImpl]
    public extern void SetDefaultCharacterFormat(ITextCharacterFormat value);

    [MethodImpl]
    public extern void SetDefaultParagraphFormat(ITextParagraphFormat value);

    [MethodImpl]
    public extern void SetText(TextSetOptions options, string value);

    [MethodImpl]
    public extern void Undo();

    public extern bool AlignmentIncludesTrailingWhitespace { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IgnoreTrailingCharacterSpacing { [MethodImpl] get; [MethodImpl] set; }
  }
}
