// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrinting3DCompositeMaterialGroupFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [ExclusiveTo(typeof (Printing3DCompositeMaterialGroup))]
  [Guid(3499019539, 37631, 17322, 166, 39, 141, 67, 194, 44, 129, 126)]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  internal interface IPrinting3DCompositeMaterialGroupFactory
  {
    Printing3DCompositeMaterialGroup Create(uint MaterialGroupId);
  }
}
