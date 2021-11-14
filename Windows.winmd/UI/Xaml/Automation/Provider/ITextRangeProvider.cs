// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.ITextRangeProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Text;

namespace Windows.UI.Xaml.Automation.Provider
{
  [Guid(41183373, 1769, 20326, 148, 70, 40, 165, 190, 152, 251, 208)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ITextRangeProvider
  {
    ITextRangeProvider Clone();

    bool Compare(ITextRangeProvider textRangeProvider);

    int CompareEndpoints(
      TextPatternRangeEndpoint endpoint,
      ITextRangeProvider textRangeProvider,
      TextPatternRangeEndpoint targetEndpoint);

    void ExpandToEnclosingUnit(TextUnit unit);

    ITextRangeProvider FindAttribute(
      int attributeId,
      object value,
      bool backward);

    ITextRangeProvider FindText(string text, bool backward, bool ignoreCase);

    object GetAttributeValue(int attributeId);

    void GetBoundingRectangles(out double[] returnValue);

    IRawElementProviderSimple GetEnclosingElement();

    string GetText(int maxLength);

    int Move(TextUnit unit, int count);

    int MoveEndpointByUnit(TextPatternRangeEndpoint endpoint, TextUnit unit, int count);

    void MoveEndpointByRange(
      TextPatternRangeEndpoint endpoint,
      ITextRangeProvider textRangeProvider,
      TextPatternRangeEndpoint targetEndpoint);

    void Select();

    void AddToSelection();

    void RemoveFromSelection();

    void ScrollIntoView(bool alignToTop);

    IRawElementProviderSimple[] GetChildren();
  }
}
