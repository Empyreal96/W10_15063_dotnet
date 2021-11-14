// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrinting3DTexture2CoordMaterialGroup2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [ExclusiveTo(typeof (Printing3DTexture2CoordMaterialGroup))]
  [ContractVersion(typeof (Printing3DContract), 131072)]
  [Guid(1778113466, 45358, 17051, 131, 134, 223, 82, 132, 246, 232, 15)]
  internal interface IPrinting3DTexture2CoordMaterialGroup2
  {
    Printing3DModelTexture Texture { get; set; }
  }
}
