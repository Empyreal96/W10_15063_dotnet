// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IManipulationDeltaRoutedEventArgs
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
  [Guid(1074616212, 19567, 18717, 130, 214, 53, 23, 16, 147, 153, 198)]
  [ExclusiveTo(typeof (ManipulationDeltaRoutedEventArgs))]
  [WebHostHidden]
  internal interface IManipulationDeltaRoutedEventArgs
  {
    UIElement Container { get; }

    Point Position { get; }

    bool IsInertial { get; }

    ManipulationDelta Delta { get; }

    ManipulationDelta Cumulative { get; }

    ManipulationVelocities Velocities { get; }

    bool Handled { get; set; }

    PointerDeviceType PointerDeviceType { get; }

    void Complete();
  }
}
