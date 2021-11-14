// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.SpotLight
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
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class SpotLight : CompositionLight, ISpotLight
  {
    public extern float ConstantAttenuation { [MethodImpl] get; [MethodImpl] set; }

    public extern Visual CoordinateSpace { [MethodImpl] get; [MethodImpl] set; }

    public extern Vector3 Direction { [MethodImpl] get; [MethodImpl] set; }

    public extern float InnerConeAngle { [MethodImpl] get; [MethodImpl] set; }

    public extern float InnerConeAngleInDegrees { [MethodImpl] get; [MethodImpl] set; }

    public extern Color InnerConeColor { [MethodImpl] get; [MethodImpl] set; }

    public extern float LinearAttenuation { [MethodImpl] get; [MethodImpl] set; }

    public extern Vector3 Offset { [MethodImpl] get; [MethodImpl] set; }

    public extern float OuterConeAngle { [MethodImpl] get; [MethodImpl] set; }

    public extern float OuterConeAngleInDegrees { [MethodImpl] get; [MethodImpl] set; }

    public extern Color OuterConeColor { [MethodImpl] get; [MethodImpl] set; }

    public extern float QuadraticAttenuation { [MethodImpl] get; [MethodImpl] set; }
  }
}
