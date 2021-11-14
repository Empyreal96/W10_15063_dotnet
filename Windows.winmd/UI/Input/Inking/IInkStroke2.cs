// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkStroke2
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
  [ExclusiveTo(typeof (InkStroke))]
  [Guid(1572463860, 47866, 19937, 137, 211, 32, 27, 30, 215, 216, 155)]
  internal interface IInkStroke2
  {
    Matrix3x2 PointTransform { get; set; }

    IVectorView<InkPoint> GetInkPoints();
  }
}
