// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ISpotLight
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (SpotLight))]
  [WebHostHidden]
  [Guid(1520427635, 17569, 20373, 164, 34, 143, 165, 17, 107, 219, 68)]
  internal interface ISpotLight
  {
    float ConstantAttenuation { get; set; }

    Visual CoordinateSpace { get; set; }

    Vector3 Direction { get; set; }

    float InnerConeAngle { get; set; }

    float InnerConeAngleInDegrees { get; set; }

    Color InnerConeColor { get; set; }

    float LinearAttenuation { get; set; }

    Vector3 Offset { get; set; }

    float OuterConeAngle { get; set; }

    float OuterConeAngleInDegrees { get; set; }

    Color OuterConeColor { get; set; }

    float QuadraticAttenuation { get; set; }
  }
}
