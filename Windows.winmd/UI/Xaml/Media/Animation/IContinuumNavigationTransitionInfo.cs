// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IContinuumNavigationTransitionInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(1273093037, 35750, 16388, 132, 56, 138, 144, 23, 151, 133, 67)]
  [ExclusiveTo(typeof (ContinuumNavigationTransitionInfo))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IContinuumNavigationTransitionInfo
  {
    UIElement ExitElement { get; set; }
  }
}
