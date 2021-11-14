// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IPointerPointStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ExclusiveTo(typeof (PointerPoint))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2768659341, 10778, 16702, 188, 117, 159, 56, 56, 28, 192, 105)]
  internal interface IPointerPointStatics
  {
    [Overload("GetCurrentPoint")]
    PointerPoint GetCurrentPoint(uint pointerId);

    [Overload("GetIntermediatePoints")]
    IVector<PointerPoint> GetIntermediatePoints(uint pointerId);

    [Overload("GetCurrentPointTransformed")]
    PointerPoint GetCurrentPoint(uint pointerId, IPointerPointTransform transform);

    [Overload("GetIntermediatePointsTransformed")]
    IVector<PointerPoint> GetIntermediatePoints(
      uint pointerId,
      IPointerPointTransform transform);
  }
}
