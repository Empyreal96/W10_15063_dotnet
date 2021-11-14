// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrinting3DCompositeMaterialGroup
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [ExclusiveTo(typeof (Printing3DCompositeMaterialGroup))]
  [Guid(2375314011, 16625, 18797, 165, 251, 52, 10, 90, 103, 142, 48)]
  internal interface IPrinting3DCompositeMaterialGroup
  {
    IVector<Printing3DCompositeMaterial> Composites { get; }

    uint MaterialGroupId { get; }

    IVector<uint> MaterialIndices { get; }
  }
}
