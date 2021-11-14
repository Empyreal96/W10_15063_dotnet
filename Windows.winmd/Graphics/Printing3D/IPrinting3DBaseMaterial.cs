// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrinting3DBaseMaterial
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [Guid(3505448771, 50444, 19403, 157, 4, 252, 22, 173, 206, 162, 201)]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [ExclusiveTo(typeof (Printing3DBaseMaterial))]
  internal interface IPrinting3DBaseMaterial
  {
    string Name { get; set; }

    Printing3DColorMaterial Color { get; set; }
  }
}
