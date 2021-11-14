// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Navigation.INavigationEventArgs2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Navigation
{
  [WebHostHidden]
  [ExclusiveTo(typeof (NavigationEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3690951129, 38810, 19246, 164, 155, 59, 177, 127, 222, 245, 116)]
  internal interface INavigationEventArgs2
  {
    NavigationTransitionInfo NavigationTransitionInfo { get; }
  }
}
