// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ProgressBar
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [Composable(typeof (IProgressBarFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IProgressBarStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public class ProgressBar : RangeBase, IProgressBar
  {
    [MethodImpl]
    public extern ProgressBar();

    public extern bool IsIndeterminate { [MethodImpl] get; [MethodImpl] set; }

    public extern bool ShowError { [MethodImpl] get; [MethodImpl] set; }

    public extern bool ShowPaused { [MethodImpl] get; [MethodImpl] set; }

    public extern ProgressBarTemplateSettings TemplateSettings { [MethodImpl] get; }

    public static extern DependencyProperty IsIndeterminateProperty { [MethodImpl] get; }

    public static extern DependencyProperty ShowErrorProperty { [MethodImpl] get; }

    public static extern DependencyProperty ShowPausedProperty { [MethodImpl] get; }
  }
}
