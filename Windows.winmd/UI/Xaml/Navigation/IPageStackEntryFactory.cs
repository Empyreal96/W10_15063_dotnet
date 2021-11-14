// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Navigation.IPageStackEntryFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Navigation
{
  [Guid(1146356874, 43193, 20344, 155, 132, 31, 81, 245, 136, 81, 255)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PageStackEntry))]
  [WebHostHidden]
  internal interface IPageStackEntryFactory
  {
    PageStackEntry CreateInstance(
      TypeName sourcePageType,
      object parameter,
      NavigationTransitionInfo navigationTransitionInfo);
  }
}
