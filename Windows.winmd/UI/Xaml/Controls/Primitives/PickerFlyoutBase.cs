// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.PickerFlyoutBase
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IPickerFlyoutBaseFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Static(typeof (IPickerFlyoutBaseStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class PickerFlyoutBase : FlyoutBase, IPickerFlyoutBase, IPickerFlyoutBaseOverrides
  {
    [MethodImpl]
    protected extern PickerFlyoutBase();

    [MethodImpl]
    extern void IPickerFlyoutBaseOverrides.OnConfirmed();

    [MethodImpl]
    extern bool IPickerFlyoutBaseOverrides.ShouldShowConfirmationButtons();

    public static extern DependencyProperty TitleProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern string GetTitle(DependencyObject element);

    [MethodImpl]
    public static extern void SetTitle(DependencyObject element, string value);
  }
}
