// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IImage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.PlayTo;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (Image))]
  [Guid(1230730242, 39667, 20048, 170, 144, 3, 56, 143, 48, 134, 210)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IImage
  {
    ImageSource Source { get; set; }

    Stretch Stretch { get; set; }

    Thickness NineGrid { get; set; }

    PlayToSource PlayToSource { [Deprecated("PlayToSource may be altered or unavailable for releases after Windows 10.0. Instead, use GetAsCastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    event ExceptionRoutedEventHandler ImageFailed;

    event RoutedEventHandler ImageOpened;
  }
}
