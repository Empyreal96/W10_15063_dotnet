// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.Printing3DMesh
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Printing3D
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Graphics.Printing3D.Printing3DContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  public sealed class Printing3DMesh : IPrinting3DMesh
  {
    [MethodImpl]
    public extern Printing3DMesh();

    public extern uint VertexCount { [MethodImpl] get; [MethodImpl] set; }

    public extern uint IndexCount { [MethodImpl] get; [MethodImpl] set; }

    public extern Printing3DBufferDescription VertexPositionsDescription { [MethodImpl] get; [MethodImpl] set; }

    public extern Printing3DBufferDescription VertexNormalsDescription { [MethodImpl] get; [MethodImpl] set; }

    public extern Printing3DBufferDescription TriangleIndicesDescription { [MethodImpl] get; [MethodImpl] set; }

    public extern Printing3DBufferDescription TriangleMaterialIndicesDescription { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern IBuffer GetVertexPositions();

    [MethodImpl]
    public extern void CreateVertexPositions(uint value);

    [MethodImpl]
    public extern IBuffer GetVertexNormals();

    [MethodImpl]
    public extern void CreateVertexNormals(uint value);

    [MethodImpl]
    public extern IBuffer GetTriangleIndices();

    [MethodImpl]
    public extern void CreateTriangleIndices(uint value);

    [MethodImpl]
    public extern IBuffer GetTriangleMaterialIndices();

    [MethodImpl]
    public extern void CreateTriangleMaterialIndices(uint value);

    public extern IPropertySet BufferDescriptionSet { [MethodImpl] get; }

    public extern IPropertySet BufferSet { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Printing3DMeshVerificationResult> VerifyAsync(
      Printing3DMeshVerificationMode value);
  }
}
