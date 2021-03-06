// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input;

namespace Windows.UI.Xaml.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ManipulationInertiaStartingRoutedEventArgs : 
    RoutedEventArgs,
    IManipulationInertiaStartingRoutedEventArgs
  {
    [MethodImpl]
    public extern ManipulationInertiaStartingRoutedEventArgs();

    public extern UIElement Container { [MethodImpl] get; }

    public extern InertiaExpansionBehavior ExpansionBehavior { [MethodImpl] get; [MethodImpl] set; }

    public extern InertiaRotationBehavior RotationBehavior { [MethodImpl] get; [MethodImpl] set; }

    public extern InertiaTranslationBehavior TranslationBehavior { [MethodImpl] get; [MethodImpl] set; }

    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    public extern PointerDeviceType PointerDeviceType { [MethodImpl] get; }

    public extern ManipulationDelta Delta { [MethodImpl] get; }

    public extern ManipulationDelta Cumulative { [MethodImpl] get; }

    public extern ManipulationVelocities Velocities { [MethodImpl] get; }
  }
}
