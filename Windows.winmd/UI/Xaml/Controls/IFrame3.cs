// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFrame3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1686776653, 21450, 19290, 170, 142, 60, 199, 68, 15, 74, 103)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Frame))]
  internal interface IFrame3
  {
    void GoBack(NavigationTransitionInfo transitionInfoOverride);
  }
}
