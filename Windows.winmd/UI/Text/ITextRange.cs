// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.ITextRange
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Text
{
  [Guid(1537101399, 49266, 17056, 137, 69, 175, 80, 62, 229, 71, 104)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ITextRange
  {
    char Character { get; set; }

    ITextCharacterFormat CharacterFormat { get; set; }

    ITextRange FormattedText { get; set; }

    int EndPosition { get; set; }

    RangeGravity Gravity { get; set; }

    int Length { get; }

    string Link { get; set; }

    ITextParagraphFormat ParagraphFormat { get; set; }

    int StartPosition { get; set; }

    int StoryLength { get; }

    string Text { get; set; }

    bool CanPaste(int format);

    void ChangeCase(LetterCase value);

    void Collapse(bool value);

    void Copy();

    void Cut();

    int Delete(TextRangeUnit unit, int count);

    int EndOf(TextRangeUnit unit, bool extend);

    int Expand(TextRangeUnit unit);

    int FindText(string value, int scanLength, FindOptions options);

    void GetCharacterUtf32(out uint value, int offset);

    ITextRange GetClone();

    int GetIndex(TextRangeUnit unit);

    void GetPoint(
      HorizontalCharacterAlignment horizontalAlign,
      VerticalCharacterAlignment verticalAlign,
      PointOptions options,
      out Point point);

    void GetRect(PointOptions options, out Rect rect, out int hit);

    void GetText(TextGetOptions options, out string value);

    void GetTextViaStream(TextGetOptions options, IRandomAccessStream value);

    bool InRange(ITextRange range);

    void InsertImage(
      int width,
      int height,
      int ascent,
      VerticalCharacterAlignment verticalAlign,
      string alternateText,
      IRandomAccessStream value);

    bool InStory(ITextRange range);

    bool IsEqual(ITextRange range);

    int Move(TextRangeUnit unit, int count);

    int MoveEnd(TextRangeUnit unit, int count);

    int MoveStart(TextRangeUnit unit, int count);

    void Paste(int format);

    void ScrollIntoView(PointOptions value);

    void MatchSelection();

    void SetIndex(TextRangeUnit unit, int index, bool extend);

    void SetPoint(Point point, PointOptions options, bool extend);

    void SetRange(int startPosition, int endPosition);

    void SetText(TextSetOptions options, string value);

    void SetTextViaStream(TextSetOptions options, IRandomAccessStream value);

    int StartOf(TextRangeUnit unit, bool extend);
  }
}
