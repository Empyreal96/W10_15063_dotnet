// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentDialogStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ContentDialog))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(848831922, 36784, 16677, 187, 7, 231, 154, 90, 3, 129, 159)]
  internal interface IContentDialogStatics2
  {
    DependencyProperty CloseButtonTextProperty { get; }

    DependencyProperty CloseButtonCommandProperty { get; }

    DependencyProperty CloseButtonCommandParameterProperty { get; }

    DependencyProperty PrimaryButtonStyleProperty { get; }

    DependencyProperty SecondaryButtonStyleProperty { get; }

    DependencyProperty CloseButtonStyleProperty { get; }

    DependencyProperty DefaultButtonProperty { get; }
  }
}
