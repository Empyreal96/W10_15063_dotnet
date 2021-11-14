// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrinting3DTexture2CoordMaterialGroup
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [ExclusiveTo(typeof (Printing3DTexture2CoordMaterialGroup))]
  [Guid(1652391079, 28048, 20409, 159, 196, 159, 239, 243, 223, 168, 146)]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  internal interface IPrinting3DTexture2CoordMaterialGroup
  {
    IVector<Printing3DTexture2CoordMaterial> Texture2Coords { get; }

    uint MaterialGroupId { get; }
  }
}
