// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IPaneThemeTransition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [Guid(1191766926, 19452, 60998, 212, 249, 112, 141, 239, 63, 187, 43)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PaneThemeTransition))]
  internal interface IPaneThemeTransition
  {
    EdgeTransitionLocation Edge { get; set; }
  }
}
