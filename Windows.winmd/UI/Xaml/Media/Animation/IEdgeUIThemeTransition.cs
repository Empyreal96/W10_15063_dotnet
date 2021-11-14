// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IEdgeUIThemeTransition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(1552335259, 18903, 6636, 207, 25, 131, 167, 60, 109, 231, 94)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EdgeUIThemeTransition))]
  [WebHostHidden]
  internal interface IEdgeUIThemeTransition
  {
    EdgeTransitionLocation Edge { get; set; }
  }
}
