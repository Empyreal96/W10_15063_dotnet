// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.Printing3DBaseMaterialGroup
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IPrinting3DBaseMaterialGroupFactory), 65536, "Windows.Graphics.Printing3D.Printing3DContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Printing3DBaseMaterialGroup : IPrinting3DBaseMaterialGroup
  {
    [MethodImpl]
    public extern Printing3DBaseMaterialGroup(uint MaterialGroupId);

    public extern IVector<Printing3DBaseMaterial> Bases { [MethodImpl] get; }

    public extern uint MaterialGroupId { [MethodImpl] get; }
  }
}
