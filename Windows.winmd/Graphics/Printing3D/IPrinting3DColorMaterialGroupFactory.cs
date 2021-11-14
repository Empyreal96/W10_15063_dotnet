// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrinting3DColorMaterialGroupFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [ExclusiveTo(typeof (Printing3DColorMaterialGroup))]
  [Guid(1909689709, 45546, 19035, 188, 84, 25, 198, 95, 61, 240, 68)]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  internal interface IPrinting3DColorMaterialGroupFactory
  {
    Printing3DColorMaterialGroup Create(uint MaterialGroupId);
  }
}
