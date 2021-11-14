﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.ManipulationCompletedRoutedEventArgs
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
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ManipulationCompletedRoutedEventArgs : 
    RoutedEventArgs,
    IManipulationCompletedRoutedEventArgs
  {
    [MethodImpl]
    public extern ManipulationCompletedRoutedEventArgs();

    public extern UIElement Container { [MethodImpl] get; }

    public extern Point Position { [MethodImpl] get; }

    public extern bool IsInertial { [MethodImpl] get; }

    public extern ManipulationDelta Cumulative { [MethodImpl] get; }

    public extern ManipulationVelocities Velocities { [MethodImpl] get; }

    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    public extern PointerDeviceType PointerDeviceType { [MethodImpl] get; }
  }
}
