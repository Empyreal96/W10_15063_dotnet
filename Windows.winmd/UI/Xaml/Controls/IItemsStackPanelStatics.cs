// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemsStackPanelStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ItemsStackPanel))]
  [Guid(3391477311, 1103, 19307, 179, 21, 11, 96, 224, 180, 248, 125)]
  internal interface IItemsStackPanelStatics
  {
    DependencyProperty GroupPaddingProperty { get; }

    DependencyProperty OrientationProperty { get; }

    DependencyProperty GroupHeaderPlacementProperty { get; }

    DependencyProperty CacheLengthProperty { get; }
  }
}
