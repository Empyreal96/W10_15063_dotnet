// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.Path
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Shapes
{
  [WebHostHidden]
  [Composable(typeof (IPathFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPathStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class Path : Shape, IPath
  {
    [MethodImpl]
    public extern Path();

    public extern Geometry Data { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty DataProperty { [MethodImpl] get; }
  }
}
