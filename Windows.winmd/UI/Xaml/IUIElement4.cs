// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUIElement4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ExclusiveTo(typeof (UIElement))]
  [Guid(1762942164, 6554, 18007, 158, 87, 233, 158, 143, 19, 103, 18)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IUIElement4
  {
    FlyoutBase ContextFlyout { get; set; }

    bool ExitDisplayModeOnAccessKeyInvoked { get; set; }

    bool IsAccessKeyScope { get; set; }

    DependencyObject AccessKeyScopeOwner { get; set; }

    string AccessKey { get; set; }

    event TypedEventHandler<UIElement, ContextRequestedEventArgs> ContextRequested;

    event TypedEventHandler<UIElement, RoutedEventArgs> ContextCanceled;

    event TypedEventHandler<UIElement, AccessKeyDisplayRequestedEventArgs> AccessKeyDisplayRequested;

    event TypedEventHandler<UIElement, AccessKeyDisplayDismissedEventArgs> AccessKeyDisplayDismissed;

    event TypedEventHandler<UIElement, AccessKeyInvokedEventArgs> AccessKeyInvoked;
  }
}
