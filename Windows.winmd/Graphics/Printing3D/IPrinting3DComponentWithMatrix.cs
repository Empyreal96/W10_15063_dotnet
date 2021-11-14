// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrinting3DComponentWithMatrix
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Graphics.Printing3D
{
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [Guid(846852917, 3824, 17771, 154, 33, 73, 190, 190, 139, 81, 194)]
  [ExclusiveTo(typeof (Printing3DComponentWithMatrix))]
  internal interface IPrinting3DComponentWithMatrix
  {
    Printing3DComponent Component { get; set; }

    Matrix4x4 Matrix { get; set; }
  }
}
