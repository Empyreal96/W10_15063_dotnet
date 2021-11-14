// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPageOverrides
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Navigation;

namespace Windows.UI.Xaml.Controls
{
  [Guid(587963576, 13337, 17158, 170, 190, 74, 142, 104, 13, 54, 39)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Page))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPageOverrides
  {
    void OnNavigatedFrom(NavigationEventArgs e);

    void OnNavigatedTo(NavigationEventArgs e);

    void OnNavigatingFrom(NavigatingCancelEventArgs e);
  }
}
