// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrinting3DBaseMaterialGroupFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [ExclusiveTo(typeof (Printing3DBaseMaterialGroup))]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [Guid(1544898268, 34455, 16787, 151, 107, 132, 187, 65, 22, 229, 191)]
  internal interface IPrinting3DBaseMaterialGroupFactory
  {
    Printing3DBaseMaterialGroup Create(uint MaterialGroupId);
  }
}
