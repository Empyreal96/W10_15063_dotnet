// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.Printing3DModelTexture
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Graphics.Printing3D.Printing3DContract")]
  public sealed class Printing3DModelTexture : IPrinting3DModelTexture
  {
    [MethodImpl]
    public extern Printing3DModelTexture();

    public extern Printing3DTextureResource TextureResource { [MethodImpl] get; [MethodImpl] set; }

    public extern Printing3DTextureEdgeBehavior TileStyleU { [MethodImpl] get; [MethodImpl] set; }

    public extern Printing3DTextureEdgeBehavior TileStyleV { [MethodImpl] get; [MethodImpl] set; }
  }
}
