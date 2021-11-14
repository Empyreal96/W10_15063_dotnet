// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrinting3DModelTexture
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [ExclusiveTo(typeof (Printing3DModelTexture))]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [Guid(1571802881, 46493, 18492, 151, 187, 164, 213, 70, 209, 199, 92)]
  internal interface IPrinting3DModelTexture
  {
    Printing3DTextureResource TextureResource { get; set; }

    Printing3DTextureEdgeBehavior TileStyleU { get; set; }

    Printing3DTextureEdgeBehavior TileStyleV { get; set; }
  }
}
