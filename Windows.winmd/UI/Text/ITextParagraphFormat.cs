// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.ITextParagraphFormat
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(754503590, 18038, 18826, 147, 245, 187, 219, 252, 11, 216, 131)]
  [WebHostHidden]
  public interface ITextParagraphFormat
  {
    ParagraphAlignment Alignment { get; set; }

    float FirstLineIndent { get; }

    FormatEffect KeepTogether { get; set; }

    FormatEffect KeepWithNext { get; set; }

    float LeftIndent { get; }

    float LineSpacing { get; }

    LineSpacingRule LineSpacingRule { get; }

    MarkerAlignment ListAlignment { get; set; }

    int ListLevelIndex { get; set; }

    int ListStart { get; set; }

    MarkerStyle ListStyle { get; set; }

    float ListTab { get; set; }

    MarkerType ListType { get; set; }

    FormatEffect NoLineNumber { get; set; }

    FormatEffect PageBreakBefore { get; set; }

    float RightIndent { get; set; }

    FormatEffect RightToLeft { get; set; }

    ParagraphStyle Style { get; set; }

    float SpaceAfter { get; set; }

    float SpaceBefore { get; set; }

    FormatEffect WidowControl { get; set; }

    int TabCount { get; }

    void AddTab(float position, TabAlignment align, TabLeader leader);

    void ClearAllTabs();

    void DeleteTab(float position);

    ITextParagraphFormat GetClone();

    void GetTab(int index, out float position, out TabAlignment align, out TabLeader leader);

    bool IsEqual(ITextParagraphFormat format);

    void SetClone(ITextParagraphFormat format);

    void SetIndents(float start, float left, float right);

    void SetLineSpacing(LineSpacingRule rule, float spacing);
  }
}
