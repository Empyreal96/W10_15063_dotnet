// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.ITextProvider2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3743238332, 1159, 20095, 157, 94, 240, 158, 119, 228, 18, 70)]
  [WebHostHidden]
  public interface ITextProvider2 : ITextProvider
  {
    ITextRangeProvider RangeFromAnnotation(
      IRawElementProviderSimple annotationElement);

    ITextRangeProvider GetCaretRange(out bool isActive);
  }
}
