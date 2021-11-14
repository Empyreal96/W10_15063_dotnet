// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IGroupStyle
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(1909075979, 47262, 16772, 176, 223, 169, 233, 84, 71, 222, 141)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (GroupStyle))]
  internal interface IGroupStyle
  {
    ItemsPanelTemplate Panel { get; set; }

    Style ContainerStyle { [Deprecated("ContainerStyle may be altered or unavailable for releases after Windows 8.1, and is not supported for ItemsControl.GroupStyle.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("ContainerStyle may be altered or unavailable for releases after Windows 8.1, and is not supported for ItemsControl.GroupStyle.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; }

    StyleSelector ContainerStyleSelector { [Deprecated("ContainerStyleSelector may be altered or unavailable for releases after Windows 8.1, and is not supported for ItemsControl.GroupStyle.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("ContainerStyleSelector may be altered or unavailable for releases after Windows 8.1, and is not supported for ItemsControl.GroupStyle.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; }

    DataTemplate HeaderTemplate { get; set; }

    DataTemplateSelector HeaderTemplateSelector { get; set; }

    bool HidesIfEmpty { get; set; }
  }
}
