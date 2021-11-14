// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Viewbox
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [Threading(ThreadingModel.Both)]
  [ContentProperty(Name = "Child")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IViewboxStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Viewbox : FrameworkElement, IViewbox
  {
    [MethodImpl]
    public extern Viewbox();

    public extern UIElement Child { [MethodImpl] get; [MethodImpl] set; }

    public extern Stretch Stretch { [MethodImpl] get; [MethodImpl] set; }

    public extern StretchDirection StretchDirection { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty StretchProperty { [MethodImpl] get; }

    public static extern DependencyProperty StretchDirectionProperty { [MethodImpl] get; }
  }
}
