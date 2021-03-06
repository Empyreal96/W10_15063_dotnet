// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Control))]
  [Guid(2828083811, 10577, 20312, 169, 197, 90, 19, 78, 170, 127, 7)]
  [WebHostHidden]
  internal interface IControl
  {
    double FontSize { get; set; }

    FontFamily FontFamily { get; set; }

    FontWeight FontWeight { get; set; }

    FontStyle FontStyle { get; set; }

    FontStretch FontStretch { get; set; }

    int CharacterSpacing { get; set; }

    Brush Foreground { get; set; }

    bool IsTabStop { get; set; }

    bool IsEnabled { get; set; }

    int TabIndex { get; set; }

    KeyboardNavigationMode TabNavigation { get; set; }

    ControlTemplate Template { get; set; }

    Thickness Padding { get; set; }

    HorizontalAlignment HorizontalContentAlignment { get; set; }

    VerticalAlignment VerticalContentAlignment { get; set; }

    Brush Background { get; set; }

    Thickness BorderThickness { get; set; }

    Brush BorderBrush { get; set; }

    FocusState FocusState { get; }

    event DependencyPropertyChangedEventHandler IsEnabledChanged;

    bool ApplyTemplate();

    bool Focus(FocusState value);
  }
}
