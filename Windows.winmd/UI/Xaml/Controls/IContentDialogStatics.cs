// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentDialogStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(598427558, 20618, 20275, 183, 134, 242, 250, 150, 216, 105, 175)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContentDialog))]
  [WebHostHidden]
  internal interface IContentDialogStatics
  {
    DependencyProperty TitleProperty { get; }

    DependencyProperty TitleTemplateProperty { get; }

    DependencyProperty FullSizeDesiredProperty { get; }

    DependencyProperty PrimaryButtonTextProperty { get; }

    DependencyProperty SecondaryButtonTextProperty { get; }

    DependencyProperty PrimaryButtonCommandProperty { get; }

    DependencyProperty SecondaryButtonCommandProperty { get; }

    DependencyProperty PrimaryButtonCommandParameterProperty { get; }

    DependencyProperty SecondaryButtonCommandParameterProperty { get; }

    DependencyProperty IsPrimaryButtonEnabledProperty { get; }

    DependencyProperty IsSecondaryButtonEnabledProperty { get; }
  }
}
