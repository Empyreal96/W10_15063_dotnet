// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.GroupStyle
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Data;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IGroupStyleFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class GroupStyle : IGroupStyle, INotifyPropertyChanged, IGroupStyle2
  {
    [MethodImpl]
    public extern GroupStyle();

    public extern ItemsPanelTemplate Panel { [MethodImpl] get; [MethodImpl] set; }

    public extern Style ContainerStyle { [Deprecated("ContainerStyle may be altered or unavailable for releases after Windows 8.1, and is not supported for ItemsControl.GroupStyle.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("ContainerStyle may be altered or unavailable for releases after Windows 8.1, and is not supported for ItemsControl.GroupStyle.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    public extern StyleSelector ContainerStyleSelector { [Deprecated("ContainerStyleSelector may be altered or unavailable for releases after Windows 8.1, and is not supported for ItemsControl.GroupStyle.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("ContainerStyleSelector may be altered or unavailable for releases after Windows 8.1, and is not supported for ItemsControl.GroupStyle.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    public extern DataTemplate HeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    public extern DataTemplateSelector HeaderTemplateSelector { [MethodImpl] get; [MethodImpl] set; }

    public extern bool HidesIfEmpty { [MethodImpl] get; [MethodImpl] set; }

    public extern event PropertyChangedEventHandler PropertyChanged;

    public extern Style HeaderContainerStyle { [MethodImpl] get; [MethodImpl] set; }
  }
}
