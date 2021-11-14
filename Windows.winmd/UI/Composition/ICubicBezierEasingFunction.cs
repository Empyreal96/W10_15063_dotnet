// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICubicBezierEasingFunction
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (CubicBezierEasingFunction))]
  [Guid(842335846, 49640, 17657, 150, 184, 201, 138, 207, 10, 230, 152)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ICubicBezierEasingFunction
  {
    Vector2 ControlPoint1 { get; }

    Vector2 ControlPoint2 { get; }
  }
}
