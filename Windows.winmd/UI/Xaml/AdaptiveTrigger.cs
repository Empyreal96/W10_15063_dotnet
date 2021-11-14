// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.AdaptiveTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Static(typeof (IAdaptiveTriggerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IAdaptiveTriggerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public class AdaptiveTrigger : StateTriggerBase, IAdaptiveTrigger
  {
    [MethodImpl]
    public extern AdaptiveTrigger();

    public extern double MinWindowWidth { [MethodImpl] get; [MethodImpl] set; }

    public extern double MinWindowHeight { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty MinWindowWidthProperty { [MethodImpl] get; }

    public static extern DependencyProperty MinWindowHeightProperty { [MethodImpl] get; }
  }
}
