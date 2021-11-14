// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMediaPlayerPresenterFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [Guid(3866521527, 55663, 19349, 179, 60, 89, 232, 28, 177, 233, 186)]
  [ExclusiveTo(typeof (MediaPlayerPresenter))]
  internal interface IMediaPlayerPresenterFactory
  {
    MediaPlayerPresenter CreateInstance(object outer, out object inner);
  }
}
