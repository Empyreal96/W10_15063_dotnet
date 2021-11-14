// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IHoldingRoutedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input;

namespace Windows.UI.Xaml.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (HoldingRoutedEventArgs))]
  [Guid(3259432739, 55309, 17630, 141, 185, 13, 129, 94, 38, 154, 192)]
  internal interface IHoldingRoutedEventArgs
  {
    PointerDeviceType PointerDeviceType { get; }

    HoldingState HoldingState { get; }

    bool Handled { get; set; }

    Point GetPosition(UIElement relativeTo);
  }
}
