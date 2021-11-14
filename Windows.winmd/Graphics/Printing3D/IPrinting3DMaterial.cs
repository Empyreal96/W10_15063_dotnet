// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrinting3DMaterial
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [ExclusiveTo(typeof (Printing3DMaterial))]
  [Guid(932033110, 60770, 18770, 184, 91, 3, 86, 125, 124, 70, 94)]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  internal interface IPrinting3DMaterial
  {
    IVector<Printing3DBaseMaterialGroup> BaseGroups { get; }

    IVector<Printing3DColorMaterialGroup> ColorGroups { get; }

    IVector<Printing3DTexture2CoordMaterialGroup> Texture2CoordGroups { get; }

    IVector<Printing3DCompositeMaterialGroup> CompositeGroups { get; }

    IVector<Printing3DMultiplePropertyMaterialGroup> MultiplePropertyGroups { get; }
  }
}
