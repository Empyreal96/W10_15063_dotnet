// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrinting3DColorMaterialGroup
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [Guid(1731536, 43743, 16934, 175, 233, 243, 105, 160, 180, 80, 4)]
  [ExclusiveTo(typeof (Printing3DColorMaterialGroup))]
  internal interface IPrinting3DColorMaterialGroup
  {
    IVector<Printing3DColorMaterial> Colors { get; }

    uint MaterialGroupId { get; }
  }
}
