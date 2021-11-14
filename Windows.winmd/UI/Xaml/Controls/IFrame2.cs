// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFrame2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1060536199, 40794, 19204, 184, 24, 181, 84, 192, 105, 89, 122)]
  [ExclusiveTo(typeof (Frame))]
  [WebHostHidden]
  internal interface IFrame2
  {
    IVector<PageStackEntry> BackStack { get; }

    IVector<PageStackEntry> ForwardStack { get; }

    bool Navigate(TypeName sourcePageType, object parameter, NavigationTransitionInfo infoOverride);
  }
}
