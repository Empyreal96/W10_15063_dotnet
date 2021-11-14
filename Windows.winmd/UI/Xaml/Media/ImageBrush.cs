// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ImageBrush
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IImageBrushStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ImageBrush : TileBrush, IImageBrush
  {
    [MethodImpl]
    public extern ImageBrush();

    public extern ImageSource ImageSource { [MethodImpl] get; [MethodImpl] set; }

    public extern event ExceptionRoutedEventHandler ImageFailed;

    public extern event RoutedEventHandler ImageOpened;

    public static extern DependencyProperty ImageSourceProperty { [MethodImpl] get; }
  }
}
