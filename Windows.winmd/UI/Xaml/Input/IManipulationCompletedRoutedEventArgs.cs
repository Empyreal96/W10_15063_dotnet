// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IManipulationCompletedRoutedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input;

namespace Windows.UI.Xaml.Input
{
  [Guid(3048053539, 12097, 18830, 131, 25, 1, 94, 232, 167, 83, 70)]
  [ExclusiveTo(typeof (ManipulationCompletedRoutedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IManipulationCompletedRoutedEventArgs
  {
    UIElement Container { get; }

    Point Position { get; }

    bool IsInertial { get; }

    ManipulationDelta Cumulative { get; }

    ManipulationVelocities Velocities { get; }

    bool Handled { get; set; }

    PointerDeviceType PointerDeviceType { get; }
  }
}
