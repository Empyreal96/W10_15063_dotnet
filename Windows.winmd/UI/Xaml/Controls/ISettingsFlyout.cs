// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISettingsFlyout
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2198579243, 50523, 20018, 165, 28, 87, 145, 224, 36, 200, 175)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SettingsFlyout))]
  internal interface ISettingsFlyout
  {
    string Title { get; set; }

    Brush HeaderBackground { get; set; }

    Brush HeaderForeground { get; set; }

    ImageSource IconSource { get; set; }

    SettingsFlyoutTemplateSettings TemplateSettings { get; }

    event BackClickEventHandler BackClick;

    void Show();

    void ShowIndependent();

    void Hide();
  }
}
