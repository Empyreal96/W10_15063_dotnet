// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.ITappedRoutedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2694440638, 58916, 17818, 187, 29, 224, 92, 115, 226, 204, 102)]
  [ExclusiveTo(typeof (TappedRoutedEventArgs))]
  internal interface ITappedRoutedEventArgs
  {
    PointerDeviceType PointerDeviceType { get; }

    bool Handled { get; set; }

    Point GetPosition(UIElement relativeTo);
  }
}
