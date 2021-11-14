// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Visual
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IVisualFactory), CompositionType.Protected, 131072, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public class Visual : CompositionObject, IVisual, IVisual2
  {
    public extern Vector2 AnchorPoint { [MethodImpl] get; [MethodImpl] set; }

    public extern CompositionBackfaceVisibility BackfaceVisibility { [MethodImpl] get; [MethodImpl] set; }

    public extern CompositionBorderMode BorderMode { [MethodImpl] get; [MethodImpl] set; }

    public extern Vector3 CenterPoint { [MethodImpl] get; [MethodImpl] set; }

    public extern CompositionClip Clip { [MethodImpl] get; [MethodImpl] set; }

    public extern CompositionCompositeMode CompositeMode { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern Vector3 Offset { [MethodImpl] get; [MethodImpl] set; }

    public extern float Opacity { [MethodImpl] get; [MethodImpl] set; }

    public extern Quaternion Orientation { [MethodImpl] get; [MethodImpl] set; }

    public extern ContainerVisual Parent { [MethodImpl] get; }

    public extern float RotationAngle { [MethodImpl] get; [MethodImpl] set; }

    public extern float RotationAngleInDegrees { [MethodImpl] get; [MethodImpl] set; }

    public extern Vector3 RotationAxis { [MethodImpl] get; [MethodImpl] set; }

    public extern Vector3 Scale { [MethodImpl] get; [MethodImpl] set; }

    public extern Vector2 Size { [MethodImpl] get; [MethodImpl] set; }

    public extern Matrix4x4 TransformMatrix { [MethodImpl] get; [MethodImpl] set; }

    public extern Visual ParentForTransform { [MethodImpl] get; [MethodImpl] set; }

    public extern Vector3 RelativeOffsetAdjustment { [MethodImpl] get; [MethodImpl] set; }

    public extern Vector2 RelativeSizeAdjustment { [MethodImpl] get; [MethodImpl] set; }
  }
}
