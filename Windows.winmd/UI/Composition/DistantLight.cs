// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.DistantLight
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  public sealed class DistantLight : CompositionLight, IDistantLight
  {
    public extern Color Color { [MethodImpl] get; [MethodImpl] set; }

    public extern Visual CoordinateSpace { [MethodImpl] get; [MethodImpl] set; }

    public extern Vector3 Direction { [MethodImpl] get; [MethodImpl] set; }
  }
}
