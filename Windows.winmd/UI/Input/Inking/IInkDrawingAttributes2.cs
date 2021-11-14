// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkDrawingAttributes2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Inking
{
  [ExclusiveTo(typeof (InkDrawingAttributes))]
  [Guid(2091607304, 36548, 17149, 165, 165, 228, 183, 209, 213, 49, 109)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IInkDrawingAttributes2
  {
    Matrix3x2 PenTipTransform { get; set; }

    bool DrawAsHighlighter { get; set; }
  }
}
