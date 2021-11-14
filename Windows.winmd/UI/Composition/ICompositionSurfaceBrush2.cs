// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionSurfaceBrush2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [Guid(3530650837, 25845, 18066, 157, 199, 113, 182, 29, 126, 88, 128)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (CompositionSurfaceBrush))]
  [WebHostHidden]
  internal interface ICompositionSurfaceBrush2
  {
    Vector2 AnchorPoint { get; set; }

    Vector2 CenterPoint { get; set; }

    Vector2 Offset { get; set; }

    float RotationAngle { get; set; }

    float RotationAngleInDegrees { get; set; }

    Vector2 Scale { get; set; }

    Matrix3x2 TransformMatrix { get; set; }
  }
}
