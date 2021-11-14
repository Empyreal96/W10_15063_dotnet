// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrinting3DColorMaterial
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [Guid(3783891240, 31975, 17029, 163, 93, 241, 69, 201, 81, 12, 123)]
  [ExclusiveTo(typeof (Printing3DColorMaterial))]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  internal interface IPrinting3DColorMaterial
  {
    uint Value { get; set; }
  }
}
