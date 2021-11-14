// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentPresenterStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContentPresenter))]
  [WebHostHidden]
  [Guid(415402299, 55854, 17446, 184, 90, 44, 126, 33, 113, 190, 223)]
  internal interface IContentPresenterStatics
  {
    DependencyProperty ContentProperty { get; }

    DependencyProperty ContentTemplateProperty { get; }

    DependencyProperty ContentTemplateSelectorProperty { get; }

    DependencyProperty ContentTransitionsProperty { get; }

    DependencyProperty FontSizeProperty { get; }

    DependencyProperty FontFamilyProperty { get; }

    DependencyProperty FontWeightProperty { get; }

    DependencyProperty FontStyleProperty { get; }

    DependencyProperty FontStretchProperty { get; }

    DependencyProperty CharacterSpacingProperty { get; }

    DependencyProperty ForegroundProperty { get; }
  }
}
