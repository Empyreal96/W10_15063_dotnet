// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.PointKeyFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [Composable(typeof (IPointKeyFrameFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPointKeyFrameStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public class PointKeyFrame : DependencyObject, IPointKeyFrame
  {
    [MethodImpl]
    protected extern PointKeyFrame();

    public extern Point Value { [MethodImpl] get; [MethodImpl] set; }

    public extern KeyTime KeyTime { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty ValueProperty { [MethodImpl] get; }

    public static extern DependencyProperty KeyTimeProperty { [MethodImpl] get; }
  }
}
