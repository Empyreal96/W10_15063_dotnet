// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.Printing3DComponentWithMatrix
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Graphics.Printing3D
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [Activatable(65536, "Windows.Graphics.Printing3D.Printing3DContract")]
  public sealed class Printing3DComponentWithMatrix : IPrinting3DComponentWithMatrix
  {
    [MethodImpl]
    public extern Printing3DComponentWithMatrix();

    public extern Printing3DComponent Component { [MethodImpl] get; [MethodImpl] set; }

    public extern Matrix4x4 Matrix { [MethodImpl] get; [MethodImpl] set; }
  }
}
