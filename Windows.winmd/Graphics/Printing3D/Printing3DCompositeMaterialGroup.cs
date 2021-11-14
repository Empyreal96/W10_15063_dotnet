// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.Printing3DCompositeMaterialGroup
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [Activatable(typeof (IPrinting3DCompositeMaterialGroupFactory), 65536, "Windows.Graphics.Printing3D.Printing3DContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  public sealed class Printing3DCompositeMaterialGroup : 
    IPrinting3DCompositeMaterialGroup,
    IPrinting3DCompositeMaterialGroup2
  {
    [MethodImpl]
    public extern Printing3DCompositeMaterialGroup(uint MaterialGroupId);

    public extern IVector<Printing3DCompositeMaterial> Composites { [MethodImpl] get; }

    public extern uint MaterialGroupId { [MethodImpl] get; }

    public extern IVector<uint> MaterialIndices { [MethodImpl] get; }

    public extern Printing3DBaseMaterialGroup BaseMaterialGroup { [MethodImpl] get; [MethodImpl] set; }
  }
}
