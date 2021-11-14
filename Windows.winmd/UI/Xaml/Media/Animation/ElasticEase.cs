// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ElasticEase
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Static(typeof (IElasticEaseStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ElasticEase : EasingFunctionBase, IElasticEase
  {
    [MethodImpl]
    public extern ElasticEase();

    public extern int Oscillations { [MethodImpl] get; [MethodImpl] set; }

    public extern double Springiness { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty OscillationsProperty { [MethodImpl] get; }

    public static extern DependencyProperty SpringinessProperty { [MethodImpl] get; }
  }
}
