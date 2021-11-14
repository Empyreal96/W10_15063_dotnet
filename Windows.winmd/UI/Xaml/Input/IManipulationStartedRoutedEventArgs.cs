// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IManipulationStartedRoutedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input;

namespace Windows.UI.Xaml.Input
{
  [Guid(1571924485, 40832, 18614, 174, 108, 79, 17, 157, 232, 255, 19)]
  [ExclusiveTo(typeof (ManipulationStartedRoutedEventArgs))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IManipulationStartedRoutedEventArgs
  {
    UIElement Container { get; }

    Point Position { get; }

    bool Handled { get; set; }

    PointerDeviceType PointerDeviceType { get; }

    ManipulationDelta Cumulative { get; }

    void Complete();
  }
}
