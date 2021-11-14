// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.ITextProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  [WebHostHidden]
  [Guid(3680222367, 18439, 20266, 134, 120, 27, 19, 243, 198, 14, 34)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ITextProvider
  {
    ITextRangeProvider DocumentRange { get; }

    SupportedTextSelection SupportedTextSelection { get; }

    ITextRangeProvider[] GetSelection();

    ITextRangeProvider[] GetVisibleRanges();

    ITextRangeProvider RangeFromChild(IRawElementProviderSimple childElement);

    ITextRangeProvider RangeFromPoint(Point screenLocation);
  }
}
