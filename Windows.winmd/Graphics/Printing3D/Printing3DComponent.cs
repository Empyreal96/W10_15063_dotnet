// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.Printing3DComponent
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Graphics.Printing3D.Printing3DContract")]
  public sealed class Printing3DComponent : IPrinting3DComponent
  {
    [MethodImpl]
    public extern Printing3DComponent();

    public extern Printing3DMesh Mesh { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<Printing3DComponentWithMatrix> Components { [MethodImpl] get; }

    public extern Printing3DTextureResource Thumbnail { [MethodImpl] get; [MethodImpl] set; }

    public extern Printing3DObjectType Type { [MethodImpl] get; [MethodImpl] set; }

    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    public extern string PartNumber { [MethodImpl] get; [MethodImpl] set; }
  }
}
