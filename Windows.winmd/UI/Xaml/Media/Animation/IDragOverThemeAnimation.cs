// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IDragOverThemeAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (DragOverThemeAnimation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1928815351, 32337, 19051, 185, 55, 220, 75, 76, 28, 84, 88)]
  [WebHostHidden]
  internal interface IDragOverThemeAnimation
  {
    string TargetName { get; set; }

    double ToOffset { get; set; }

    AnimationDirection Direction { get; set; }
  }
}
