// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IDoubleTappedRoutedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ExclusiveTo(typeof (DoubleTappedRoutedEventArgs))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2940224548, 9951, 17652, 135, 20, 147, 89, 36, 155, 98, 211)]
  internal interface IDoubleTappedRoutedEventArgs
  {
    PointerDeviceType PointerDeviceType { get; }

    bool Handled { get; set; }

    Point GetPosition(UIElement relativeTo);
  }
}
