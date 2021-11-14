// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.Printing3DColorMaterial
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Graphics.Printing3D
{
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Graphics.Printing3D.Printing3DContract")]
  public sealed class Printing3DColorMaterial : IPrinting3DColorMaterial, IPrinting3DColorMaterial2
  {
    [MethodImpl]
    public extern Printing3DColorMaterial();

    public extern uint Value { [MethodImpl] get; [MethodImpl] set; }

    public extern Color Color { [MethodImpl] get; [MethodImpl] set; }
  }
}
