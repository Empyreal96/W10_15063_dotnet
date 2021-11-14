// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.ITransformProvider2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  [WebHostHidden]
  [Guid(2830178134, 41887, 20119, 140, 125, 193, 234, 141, 214, 51, 197)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ITransformProvider2 : ITransformProvider
  {
    bool CanZoom { get; }

    double ZoomLevel { get; }

    double MaxZoom { get; }

    double MinZoom { get; }

    void Zoom(double zoom);

    void ZoomByUnit(ZoomUnit zoomUnit);
  }
}
