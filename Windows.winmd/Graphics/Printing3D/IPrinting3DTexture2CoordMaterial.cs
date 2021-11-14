// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrinting3DTexture2CoordMaterial
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [Guid(2374257659, 2025, 18822, 152, 51, 141, 211, 212, 140, 104, 89)]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [ExclusiveTo(typeof (Printing3DTexture2CoordMaterial))]
  internal interface IPrinting3DTexture2CoordMaterial
  {
    Printing3DModelTexture Texture { get; set; }

    double U { get; set; }

    double V { get; set; }
  }
}
