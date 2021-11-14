// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrinting3DMultiplePropertyMaterialGroupFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [ExclusiveTo(typeof (Printing3DMultiplePropertyMaterialGroup))]
  [Guid(842930542, 54470, 17694, 168, 20, 77, 120, 162, 16, 254, 83)]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  internal interface IPrinting3DMultiplePropertyMaterialGroupFactory
  {
    Printing3DMultiplePropertyMaterialGroup Create(
      uint MaterialGroupId);
  }
}
