// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.ITextDocument
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Text
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3203288539, 37042, 16524, 162, 246, 10, 10, 195, 30, 51, 228)]
  public interface ITextDocument
  {
    CaretType CaretType { get; set; }

    float DefaultTabStop { get; set; }

    ITextSelection Selection { get; }

    uint UndoLimit { get; set; }

    bool CanCopy();

    bool CanPaste();

    bool CanRedo();

    bool CanUndo();

    int ApplyDisplayUpdates();

    int BatchDisplayUpdates();

    void BeginUndoGroup();

    void EndUndoGroup();

    ITextCharacterFormat GetDefaultCharacterFormat();

    ITextParagraphFormat GetDefaultParagraphFormat();

    ITextRange GetRange(int startPosition, int endPosition);

    ITextRange GetRangeFromPoint(Point point, PointOptions options);

    void GetText(TextGetOptions options, out string value);

    void LoadFromStream(TextSetOptions options, IRandomAccessStream value);

    void Redo();

    void SaveToStream(TextGetOptions options, IRandomAccessStream value);

    void SetDefaultCharacterFormat(ITextCharacterFormat value);

    void SetDefaultParagraphFormat(ITextParagraphFormat value);

    void SetText(TextSetOptions options, string value);

    void Undo();
  }
}
