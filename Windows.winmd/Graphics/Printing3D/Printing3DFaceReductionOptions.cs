// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.Printing3DFaceReductionOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [ContractVersion(typeof (Printing3DContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(196608, "Windows.Graphics.Printing3D.Printing3DContract")]
  public sealed class Printing3DFaceReductionOptions : IPrinting3DFaceReductionOptions
  {
    [MethodImpl]
    public extern Printing3DFaceReductionOptions();

    public extern double MaxReductionArea { [MethodImpl] get; [MethodImpl] set; }

    public extern uint TargetTriangleCount { [MethodImpl] get; [MethodImpl] set; }

    public extern double MaxEdgeLength { [MethodImpl] get; [MethodImpl] set; }
  }
}
