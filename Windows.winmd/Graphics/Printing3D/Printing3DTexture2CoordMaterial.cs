// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.Printing3DTexture2CoordMaterial
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Graphics.Printing3D.Printing3DContract")]
  public sealed class Printing3DTexture2CoordMaterial : IPrinting3DTexture2CoordMaterial
  {
    [MethodImpl]
    public extern Printing3DTexture2CoordMaterial();

    public extern Printing3DModelTexture Texture { [MethodImpl] get; [MethodImpl] set; }

    public extern double U { [MethodImpl] get; [MethodImpl] set; }

    public extern double V { [MethodImpl] get; [MethodImpl] set; }
  }
}
