// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrinting3DMesh
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Printing3D
{
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [ExclusiveTo(typeof (Printing3DMesh))]
  [Guid(422482140, 552, 11777, 188, 32, 197, 41, 12, 191, 50, 196)]
  internal interface IPrinting3DMesh
  {
    uint VertexCount { get; set; }

    uint IndexCount { get; set; }

    Printing3DBufferDescription VertexPositionsDescription { get; set; }

    Printing3DBufferDescription VertexNormalsDescription { get; set; }

    Printing3DBufferDescription TriangleIndicesDescription { get; set; }

    Printing3DBufferDescription TriangleMaterialIndicesDescription { get; set; }

    IBuffer GetVertexPositions();

    void CreateVertexPositions(uint value);

    IBuffer GetVertexNormals();

    void CreateVertexNormals(uint value);

    IBuffer GetTriangleIndices();

    void CreateTriangleIndices(uint value);

    IBuffer GetTriangleMaterialIndices();

    void CreateTriangleMaterialIndices(uint value);

    IPropertySet BufferDescriptionSet { get; }

    IPropertySet BufferSet { get; }

    [RemoteAsync]
    IAsyncOperation<Printing3DMeshVerificationResult> VerifyAsync(
      Printing3DMeshVerificationMode value);
  }
}
