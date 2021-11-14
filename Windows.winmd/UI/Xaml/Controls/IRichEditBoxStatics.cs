// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichEditBoxStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(4125112948, 35050, 18331, 154, 5, 55, 8, 159, 243, 14, 222)]
  [ExclusiveTo(typeof (RichEditBox))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRichEditBoxStatics
  {
    DependencyProperty IsReadOnlyProperty { get; }

    DependencyProperty AcceptsReturnProperty { get; }

    DependencyProperty TextAlignmentProperty { get; }

    DependencyProperty TextWrappingProperty { get; }

    DependencyProperty IsSpellCheckEnabledProperty { get; }

    DependencyProperty IsTextPredictionEnabledProperty { get; }

    DependencyProperty InputScopeProperty { get; }
  }
}
