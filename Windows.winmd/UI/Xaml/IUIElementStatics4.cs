// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUIElementStatics4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [Guid(487947617, 5807, 16671, 183, 116, 39, 35, 117, 164, 172, 44)]
  [ExclusiveTo(typeof (UIElement))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IUIElementStatics4
  {
    DependencyProperty ContextFlyoutProperty { get; }

    DependencyProperty ExitDisplayModeOnAccessKeyInvokedProperty { get; }

    DependencyProperty IsAccessKeyScopeProperty { get; }

    DependencyProperty AccessKeyScopeOwnerProperty { get; }

    DependencyProperty AccessKeyProperty { get; }
  }
}
