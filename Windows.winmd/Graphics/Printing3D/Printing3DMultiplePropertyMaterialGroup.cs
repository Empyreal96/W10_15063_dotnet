// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.Printing3DMultiplePropertyMaterialGroup
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [Activatable(typeof (IPrinting3DMultiplePropertyMaterialGroupFactory), 65536, "Windows.Graphics.Printing3D.Printing3DContract")]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Printing3DMultiplePropertyMaterialGroup : 
    IPrinting3DMultiplePropertyMaterialGroup
  {
    [MethodImpl]
    public extern Printing3DMultiplePropertyMaterialGroup(uint MaterialGroupId);

    public extern IVector<Printing3DMultiplePropertyMaterial> MultipleProperties { [MethodImpl] get; }

    public extern IVector<uint> MaterialGroupIndices { [MethodImpl] get; }

    public extern uint MaterialGroupId { [MethodImpl] get; }
  }
}
