// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.PointLight
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
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class PointLight : CompositionLight, IPointLight
  {
    public extern Color Color { [MethodImpl] get; [MethodImpl] set; }

    public extern float ConstantAttenuation { [MethodImpl] get; [MethodImpl] set; }

    public extern Visual CoordinateSpace { [MethodImpl] get; [MethodImpl] set; }

    public extern float LinearAttenuation { [MethodImpl] get; [MethodImpl] set; }

    public extern Vector3 Offset { [MethodImpl] get; [MethodImpl] set; }

    public extern float QuadraticAttenuation { [MethodImpl] get; [MethodImpl] set; }
  }
}
