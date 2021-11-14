// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.LineGeometry
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Static(typeof (ILineGeometryStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class LineGeometry : Geometry, ILineGeometry
  {
    [MethodImpl]
    public extern LineGeometry();

    public extern Point StartPoint { [MethodImpl] get; [MethodImpl] set; }

    public extern Point EndPoint { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty StartPointProperty { [MethodImpl] get; }

    public static extern DependencyProperty EndPointProperty { [MethodImpl] get; }
  }
}
