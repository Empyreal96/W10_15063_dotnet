// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IScrollProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  [Guid(927724929, 30486, 19388, 130, 235, 217, 151, 0, 110, 169, 153)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IScrollProvider
  {
    bool HorizontallyScrollable { get; }

    double HorizontalScrollPercent { get; }

    double HorizontalViewSize { get; }

    bool VerticallyScrollable { get; }

    double VerticalScrollPercent { get; }

    double VerticalViewSize { get; }

    void Scroll(ScrollAmount horizontalAmount, ScrollAmount verticalAmount);

    void SetScrollPercent(double horizontalPercent, double verticalPercent);
  }
}
