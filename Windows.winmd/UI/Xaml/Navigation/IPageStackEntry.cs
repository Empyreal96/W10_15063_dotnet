// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Navigation.IPageStackEntry
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Navigation
{
  [ExclusiveTo(typeof (PageStackEntry))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4018672806, 37768, 19146, 133, 114, 64, 81, 148, 6, 144, 128)]
  [WebHostHidden]
  internal interface IPageStackEntry
  {
    TypeName SourcePageType { get; }

    object Parameter { get; }

    NavigationTransitionInfo NavigationTransitionInfo { get; }
  }
}
