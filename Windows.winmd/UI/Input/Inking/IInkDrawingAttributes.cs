// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkDrawingAttributes
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [Guid(2543982444, 26484, 18605, 132, 240, 72, 245, 169, 190, 116, 249)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (InkDrawingAttributes))]
  internal interface IInkDrawingAttributes
  {
    Color Color { get; set; }

    PenTipShape PenTip { get; set; }

    Size Size { get; set; }

    bool IgnorePressure { get; set; }

    bool FitToCurve { get; set; }
  }
}
