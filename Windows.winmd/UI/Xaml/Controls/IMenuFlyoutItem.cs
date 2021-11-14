// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMenuFlyoutItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(369587663, 46488, 17583, 164, 136, 195, 206, 42, 246, 211, 240)]
  [ExclusiveTo(typeof (MenuFlyoutItem))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMenuFlyoutItem
  {
    string Text { get; set; }

    ICommand Command { get; set; }

    object CommandParameter { get; set; }

    event RoutedEventHandler Click;
  }
}
