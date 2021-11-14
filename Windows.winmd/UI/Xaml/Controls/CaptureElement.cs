// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.CaptureElement
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Static(typeof (ICaptureElementStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class CaptureElement : FrameworkElement, ICaptureElement
  {
    [MethodImpl]
    public extern CaptureElement();

    public extern MediaCapture Source { [MethodImpl] get; [MethodImpl] set; }

    public extern Stretch Stretch { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty SourceProperty { [MethodImpl] get; }

    public static extern DependencyProperty StretchProperty { [MethodImpl] get; }
  }
}
