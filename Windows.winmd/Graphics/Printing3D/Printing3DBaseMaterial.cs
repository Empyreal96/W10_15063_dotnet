// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.Printing3DBaseMaterial
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [Static(typeof (IPrinting3DBaseMaterialStatics), 65536, "Windows.Graphics.Printing3D.Printing3DContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Graphics.Printing3D.Printing3DContract")]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class Printing3DBaseMaterial : IPrinting3DBaseMaterial
  {
    [MethodImpl]
    public extern Printing3DBaseMaterial();

    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    public extern Printing3DColorMaterial Color { [MethodImpl] get; [MethodImpl] set; }

    public static extern string Abs { [MethodImpl] get; }

    public static extern string Pla { [MethodImpl] get; }
  }
}
