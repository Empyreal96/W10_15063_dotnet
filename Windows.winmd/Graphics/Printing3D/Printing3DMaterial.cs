// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.Printing3DMaterial
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
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Graphics.Printing3D.Printing3DContract")]
  public sealed class Printing3DMaterial : IPrinting3DMaterial
  {
    [MethodImpl]
    public extern Printing3DMaterial();

    public extern IVector<Printing3DBaseMaterialGroup> BaseGroups { [MethodImpl] get; }

    public extern IVector<Printing3DColorMaterialGroup> ColorGroups { [MethodImpl] get; }

    public extern IVector<Printing3DTexture2CoordMaterialGroup> Texture2CoordGroups { [MethodImpl] get; }

    public extern IVector<Printing3DCompositeMaterialGroup> CompositeGroups { [MethodImpl] get; }

    public extern IVector<Printing3DMultiplePropertyMaterialGroup> MultiplePropertyGroups { [MethodImpl] get; }
  }
}
