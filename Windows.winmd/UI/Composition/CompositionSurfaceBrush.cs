// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionSurfaceBrush
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class CompositionSurfaceBrush : 
    CompositionBrush,
    ICompositionSurfaceBrush,
    ICompositionSurfaceBrush2
  {
    public extern CompositionBitmapInterpolationMode BitmapInterpolationMode { [MethodImpl] get; [MethodImpl] set; }

    public extern float HorizontalAlignmentRatio { [MethodImpl] get; [MethodImpl] set; }

    public extern CompositionStretch Stretch { [MethodImpl] get; [MethodImpl] set; }

    public extern ICompositionSurface Surface { [MethodImpl] get; [MethodImpl] set; }

    public extern float VerticalAlignmentRatio { [MethodImpl] get; [MethodImpl] set; }

    public extern Vector2 AnchorPoint { [MethodImpl] get; [MethodImpl] set; }

    public extern Vector2 CenterPoint { [MethodImpl] get; [MethodImpl] set; }

    public extern Vector2 Offset { [MethodImpl] get; [MethodImpl] set; }

    public extern float RotationAngle { [MethodImpl] get; [MethodImpl] set; }

    public extern float RotationAngleInDegrees { [MethodImpl] get; [MethodImpl] set; }

    public extern Vector2 Scale { [MethodImpl] get; [MethodImpl] set; }

    public extern Matrix3x2 TransformMatrix { [MethodImpl] get; [MethodImpl] set; }
  }
}
