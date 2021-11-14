// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBoxStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2117596411, 42172, 17957, 136, 56, 142, 178, 169, 9, 18, 131)]
  [ExclusiveTo(typeof (TextBox))]
  internal interface ITextBoxStatics
  {
    DependencyProperty TextProperty { get; }

    DependencyProperty MaxLengthProperty { get; }

    DependencyProperty IsReadOnlyProperty { get; }

    DependencyProperty AcceptsReturnProperty { get; }

    DependencyProperty TextAlignmentProperty { get; }

    DependencyProperty TextWrappingProperty { get; }

    DependencyProperty IsSpellCheckEnabledProperty { get; }

    DependencyProperty IsTextPredictionEnabledProperty { get; }

    DependencyProperty InputScopeProperty { get; }
  }
}
