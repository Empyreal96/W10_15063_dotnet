// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrinting3DTexture2CoordMaterialGroupFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [ExclusiveTo(typeof (Printing3DTexture2CoordMaterialGroup))]
  [Guid(3417328048, 18058, 19567, 178, 162, 142, 184, 186, 141, 234, 72)]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  internal interface IPrinting3DTexture2CoordMaterialGroupFactory
  {
    Printing3DTexture2CoordMaterialGroup Create(
      uint MaterialGroupId);
  }
}
