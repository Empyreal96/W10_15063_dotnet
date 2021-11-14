// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMediaPlayerPresenterStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaPlayerPresenter))]
  [Guid(2228712702, 60116, 18775, 180, 43, 34, 49, 88, 202, 13, 231)]
  internal interface IMediaPlayerPresenterStatics
  {
    DependencyProperty MediaPlayerProperty { get; }

    DependencyProperty StretchProperty { get; }

    DependencyProperty IsFullWindowProperty { get; }
  }
}
