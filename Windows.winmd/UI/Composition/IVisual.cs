// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IVisual
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (Visual))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(293478445, 43097, 19593, 135, 59, 194, 170, 86, 103, 136, 227)]
  internal interface IVisual
  {
    Vector2 AnchorPoint { get; set; }

    CompositionBackfaceVisibility BackfaceVisibility { get; set; }

    CompositionBorderMode BorderMode { get; set; }

    Vector3 CenterPoint { get; set; }

    CompositionClip Clip { get; set; }

    CompositionCompositeMode CompositeMode { get; set; }

    bool IsVisible { get; set; }

    Vector3 Offset { get; set; }

    float Opacity { get; set; }

    Quaternion Orientation { get; set; }

    ContainerVisual Parent { get; }

    float RotationAngle { get; set; }

    float RotationAngleInDegrees { get; set; }

    Vector3 RotationAxis { get; set; }

    Vector3 Scale { get; set; }

    Vector2 Size { get; set; }

    Matrix4x4 TransformMatrix { get; set; }
  }
}
