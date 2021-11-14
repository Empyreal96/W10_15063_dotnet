// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IRangeValueProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  [Guid(2206872744, 32095, 16505, 175, 3, 195, 208, 21, 233, 52, 19)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IRangeValueProvider
  {
    bool IsReadOnly { get; }

    double LargeChange { get; }

    double Maximum { get; }

    double Minimum { get; }

    double SmallChange { get; }

    double Value { get; }

    void SetValue(double value);
  }
}
