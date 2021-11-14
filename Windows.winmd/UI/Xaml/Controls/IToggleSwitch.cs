// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IToggleSwitch
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ToggleSwitch))]
  [WebHostHidden]
  [Guid(857575168, 50681, 18085, 182, 200, 237, 229, 57, 48, 69, 103)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IToggleSwitch
  {
    bool IsOn { get; set; }

    object Header { get; set; }

    DataTemplate HeaderTemplate { get; set; }

    object OnContent { get; set; }

    DataTemplate OnContentTemplate { get; set; }

    object OffContent { get; set; }

    DataTemplate OffContentTemplate { get; set; }

    ToggleSwitchTemplateSettings TemplateSettings { get; }

    event RoutedEventHandler Toggled;
  }
}
