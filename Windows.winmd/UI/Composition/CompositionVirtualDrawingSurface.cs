// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionVirtualDrawingSurface
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (ICompositionVirtualDrawingSurfaceFactory), CompositionType.Protected, 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public class CompositionVirtualDrawingSurface : 
    CompositionDrawingSurface,
    ICompositionVirtualDrawingSurface
  {
    [MethodImpl]
    public extern void Trim(RectInt32[] rects);
  }
}
