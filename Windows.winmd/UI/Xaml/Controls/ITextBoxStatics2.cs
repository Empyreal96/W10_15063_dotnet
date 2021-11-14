// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBoxStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1972564861, 20086, 20196, 142, 15, 125, 110, 26, 35, 50, 107)]
  [WebHostHidden]
  [ExclusiveTo(typeof (TextBox))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITextBoxStatics2
  {
    DependencyProperty HeaderProperty { get; }

    DependencyProperty HeaderTemplateProperty { get; }

    DependencyProperty PlaceholderTextProperty { get; }

    DependencyProperty SelectionHighlightColorProperty { get; }

    DependencyProperty PreventKeyboardDisplayOnProgrammaticFocusProperty { get; }

    DependencyProperty IsColorFontEnabledProperty { get; }
  }
}
