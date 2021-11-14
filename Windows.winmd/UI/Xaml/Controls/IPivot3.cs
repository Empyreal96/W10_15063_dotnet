// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPivot3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2512174998, 61658, 16521, 140, 101, 232, 184, 19, 84, 199, 102)]
  [ExclusiveTo(typeof (Pivot))]
  internal interface IPivot3
  {
    PivotHeaderFocusVisualPlacement HeaderFocusVisualPlacement { get; set; }

    bool IsHeaderItemsCarouselEnabled { get; set; }
  }
}
