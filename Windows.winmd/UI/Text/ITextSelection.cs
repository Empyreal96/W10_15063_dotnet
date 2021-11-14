// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.ITextSelection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  [WebHostHidden]
  [Guid(2798872356, 62095, 17162, 178, 207, 195, 67, 103, 30, 192, 233)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ITextSelection : ITextRange
  {
    SelectionOptions Options { get; set; }

    SelectionType Type { get; }

    int EndKey(TextRangeUnit unit, bool extend);

    int HomeKey(TextRangeUnit unit, bool extend);

    int MoveDown(TextRangeUnit unit, int count, bool extend);

    int MoveLeft(TextRangeUnit unit, int count, bool extend);

    int MoveRight(TextRangeUnit unit, int count, bool extend);

    int MoveUp(TextRangeUnit unit, int count, bool extend);

    void TypeText(string value);
  }
}
