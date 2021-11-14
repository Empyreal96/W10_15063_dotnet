// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ISettingsFlyoutTemplateSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(3169930256, 52903, 17393, 157, 104, 87, 96, 93, 237, 105, 212)]
  [ExclusiveTo(typeof (SettingsFlyoutTemplateSettings))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface ISettingsFlyoutTemplateSettings
  {
    Brush HeaderBackground { get; }

    Brush HeaderForeground { get; }

    Brush BorderBrush { get; }

    Thickness BorderThickness { get; }

    ImageSource IconSource { get; }

    TransitionCollection ContentTransitions { get; }
  }
}
