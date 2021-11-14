// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrinting3DMeshVerificationResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [Guid(425095610, 59706, 20106, 164, 111, 222, 168, 232, 82, 25, 126)]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [ExclusiveTo(typeof (Printing3DMeshVerificationResult))]
  internal interface IPrinting3DMeshVerificationResult
  {
    bool IsValid { get; }

    IVectorView<uint> NonmanifoldTriangles { get; }

    IVectorView<uint> ReversedNormalTriangles { get; }
  }
}
