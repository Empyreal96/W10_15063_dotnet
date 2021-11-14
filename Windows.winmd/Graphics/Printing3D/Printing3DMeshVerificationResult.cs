// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.Printing3DMeshVerificationResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  public sealed class Printing3DMeshVerificationResult : IPrinting3DMeshVerificationResult
  {
    public extern bool IsValid { [MethodImpl] get; }

    public extern IVectorView<uint> NonmanifoldTriangles { [MethodImpl] get; }

    public extern IVectorView<uint> ReversedNormalTriangles { [MethodImpl] get; }
  }
}
