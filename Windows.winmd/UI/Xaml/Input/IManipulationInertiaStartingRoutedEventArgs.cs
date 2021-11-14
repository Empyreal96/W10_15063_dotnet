// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IManipulationInertiaStartingRoutedEventArgs
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
  [Guid(610963881, 51779, 19467, 172, 239, 129, 232, 184, 20, 117, 32)]
  [ExclusiveTo(typeof (ManipulationInertiaStartingRoutedEventArgs))]
  internal interface IManipulationInertiaStartingRoutedEventArgs
  {
    UIElement Container { get; }

    InertiaExpansionBehavior ExpansionBehavior { get; set; }

    InertiaRotationBehavior RotationBehavior { get; set; }

    InertiaTranslationBehavior TranslationBehavior { get; set; }

    bool Handled { get; set; }

    PointerDeviceType PointerDeviceType { get; }

    ManipulationDelta Delta { get; }

    ManipulationDelta Cumulative { get; }

    ManipulationVelocities Velocities { get; }
  }
}
