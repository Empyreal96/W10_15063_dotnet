// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.BitmapSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Media.Imaging
{
  [WebHostHidden]
  [Composable(typeof (IBitmapSourceFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IBitmapSourceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class BitmapSource : ImageSource, IBitmapSource
  {
    [MethodImpl]
    protected extern BitmapSource();

    public extern int PixelWidth { [MethodImpl] get; }

    public extern int PixelHeight { [MethodImpl] get; }

    [MethodImpl]
    public extern void SetSource(IRandomAccessStream streamSource);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetSourceAsync(IRandomAccessStream streamSource);

    public static extern DependencyProperty PixelWidthProperty { [MethodImpl] get; }

    public static extern DependencyProperty PixelHeightProperty { [MethodImpl] get; }
  }
}
