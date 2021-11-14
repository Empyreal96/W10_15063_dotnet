// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkStrokeBuilder3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Inking
{
  [ExclusiveTo(typeof (InkStrokeBuilder))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2999394253, 21618, 18097, 168, 29, 195, 122, 61, 22, 148, 65)]
  internal interface IInkStrokeBuilder3
  {
    InkStroke CreateStrokeFromInkPoints(
      IIterable<InkPoint> inkPoints,
      Matrix3x2 transform,
      IReference<DateTime> strokeStartedTime,
      IReference<TimeSpan> strokeDuration);
  }
}
