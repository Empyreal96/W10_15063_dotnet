// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ProgressRing
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IProgressRingStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ProgressRing : Control, IProgressRing
  {
    [MethodImpl]
    public extern ProgressRing();

    public extern bool IsActive { [MethodImpl] get; [MethodImpl] set; }

    public extern ProgressRingTemplateSettings TemplateSettings { [MethodImpl] get; }

    public static extern DependencyProperty IsActiveProperty { [MethodImpl] get; }
  }
}
