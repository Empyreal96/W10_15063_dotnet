// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkStrokeBuilder2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Inking
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (InkStrokeBuilder))]
  [Guid(3179461671, 29471, 19644, 187, 191, 109, 70, 128, 68, 241, 229)]
  internal interface IInkStrokeBuilder2
  {
    InkStroke CreateStrokeFromInkPoints(IIterable<InkPoint> inkPoints, Matrix3x2 transform);
  }
}
