// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.INavigationTransitionInfoFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (NavigationTransitionInfo))]
  [WebHostHidden]
  [Guid(3992254677, 44899, 20395, 157, 74, 135, 146, 127, 130, 221, 107)]
  internal interface INavigationTransitionInfoFactory
  {
    NavigationTransitionInfo CreateInstance(object outer, out object inner);
  }
}
