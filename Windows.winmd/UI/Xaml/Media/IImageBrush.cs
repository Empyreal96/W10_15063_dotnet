// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IImageBrush
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (ImageBrush))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2681279351, 49450, 17555, 191, 125, 243, 168, 173, 116, 181, 84)]
  [WebHostHidden]
  internal interface IImageBrush
  {
    ImageSource ImageSource { get; set; }

    event ExceptionRoutedEventHandler ImageFailed;

    event RoutedEventHandler ImageOpened;
  }
}
