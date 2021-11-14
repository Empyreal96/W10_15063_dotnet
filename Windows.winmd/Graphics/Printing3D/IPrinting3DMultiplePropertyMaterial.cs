// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrinting3DMultiplePropertyMaterial
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [Guid(631645515, 50921, 18509, 162, 20, 162, 94, 87, 118, 186, 98)]
  [ExclusiveTo(typeof (Printing3DMultiplePropertyMaterial))]
  internal interface IPrinting3DMultiplePropertyMaterial
  {
    IVector<uint> MaterialIndices { get; }
  }
}
