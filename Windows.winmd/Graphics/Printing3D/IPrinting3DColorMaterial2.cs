// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrinting3DColorMaterial2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Graphics.Printing3D
{
  [ExclusiveTo(typeof (Printing3DColorMaterial))]
  [ContractVersion(typeof (Printing3DContract), 131072)]
  [Guid(4205897810, 2799, 17641, 157, 221, 54, 238, 234, 90, 205, 68)]
  internal interface IPrinting3DColorMaterial2
  {
    Color Color { get; set; }
  }
}
