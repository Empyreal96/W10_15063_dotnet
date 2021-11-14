// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.Printing3DCompositeMaterial
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Graphics.Printing3D.Printing3DContract")]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Printing3DCompositeMaterial : IPrinting3DCompositeMaterial
  {
    [MethodImpl]
    public extern Printing3DCompositeMaterial();

    public extern IVector<double> Values { [MethodImpl] get; }
  }
}
