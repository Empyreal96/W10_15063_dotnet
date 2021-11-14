// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.PowerEase
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPowerEaseStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class PowerEase : EasingFunctionBase, IPowerEase
  {
    [MethodImpl]
    public extern PowerEase();

    public extern double Power { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty PowerProperty { [MethodImpl] get; }
  }
}
