// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IPointLight
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2978301363, 3162, 19120, 190, 220, 79, 53, 70, 148, 130, 114)]
  [ExclusiveTo(typeof (PointLight))]
  [WebHostHidden]
  internal interface IPointLight
  {
    Color Color { get; set; }

    float ConstantAttenuation { get; set; }

    Visual CoordinateSpace { get; set; }

    float LinearAttenuation { get; set; }

    Vector3 Offset { get; set; }

    float QuadraticAttenuation { get; set; }
  }
}
