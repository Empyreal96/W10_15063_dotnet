// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.BitmapIcon
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Static(typeof (IBitmapIconStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IBitmapIconStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Composable(typeof (IBitmapIconFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public class BitmapIcon : IconElement, IBitmapIcon, IBitmapIcon2
  {
    [MethodImpl]
    public extern BitmapIcon();

    public extern Uri UriSource { [MethodImpl] get; [MethodImpl] set; }

    public extern bool ShowAsMonochrome { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty ShowAsMonochromeProperty { [MethodImpl] get; }

    public static extern DependencyProperty UriSourceProperty { [MethodImpl] get; }
  }
}
