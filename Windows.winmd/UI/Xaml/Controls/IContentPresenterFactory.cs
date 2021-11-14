// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentPresenterFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(859428087, 18453, 17604, 159, 118, 104, 200, 56, 128, 239, 16)]
  [ExclusiveTo(typeof (ContentPresenter))]
  [WebHostHidden]
  internal interface IContentPresenterFactory
  {
    ContentPresenter CreateInstance(object outer, out object inner);
  }
}
