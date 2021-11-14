// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrinting3DBaseMaterialGroup
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [Guid(2498785464, 9493, 19085, 161, 240, 208, 252, 19, 208, 96, 33)]
  [ExclusiveTo(typeof (Printing3DBaseMaterialGroup))]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  internal interface IPrinting3DBaseMaterialGroup
  {
    IVector<Printing3DBaseMaterial> Bases { get; }

    uint MaterialGroupId { get; }
  }
}
