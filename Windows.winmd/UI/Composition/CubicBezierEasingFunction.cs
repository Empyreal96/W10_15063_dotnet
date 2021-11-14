// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CubicBezierEasingFunction
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class CubicBezierEasingFunction : 
    CompositionEasingFunction,
    ICubicBezierEasingFunction
  {
    public extern Vector2 ControlPoint1 { [MethodImpl] get; }

    public extern Vector2 ControlPoint2 { [MethodImpl] get; }
  }
}
