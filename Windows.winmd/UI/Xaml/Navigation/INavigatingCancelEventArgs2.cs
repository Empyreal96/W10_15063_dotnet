// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Navigation.INavigatingCancelEventArgs2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Navigation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (NavigatingCancelEventArgs))]
  [Guid(1409791748, 33095, 17219, 131, 143, 221, 30, 233, 8, 193, 55)]
  [WebHostHidden]
  internal interface INavigatingCancelEventArgs2
  {
    object Parameter { get; }

    NavigationTransitionInfo NavigationTransitionInfo { get; }
  }
}
