// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkPresenterProtractor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [Guid(2112090794, 61292, 20113, 167, 59, 91, 112, 213, 111, 189, 23)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (InkPresenterProtractor))]
  [WebHostHidden]
  internal interface IInkPresenterProtractor : IInkPresenterStencil
  {
    bool AreTickMarksVisible { get; set; }

    bool AreRaysVisible { get; set; }

    bool IsCenterMarkerVisible { get; set; }

    bool IsAngleReadoutVisible { get; set; }

    bool IsResizable { get; set; }

    double Radius { get; set; }

    Color AccentColor { get; set; }
  }
}
