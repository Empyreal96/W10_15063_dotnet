// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ICommonNavigationTransitionInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1345607314, 42325, 17956, 163, 97, 10, 145, 193, 112, 100, 115)]
  [ExclusiveTo(typeof (CommonNavigationTransitionInfo))]
  [WebHostHidden]
  internal interface ICommonNavigationTransitionInfo
  {
    bool IsStaggeringEnabled { get; set; }
  }
}
