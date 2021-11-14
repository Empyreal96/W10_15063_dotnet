// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IManipulationCompletedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ExclusiveTo(typeof (ManipulationCompletedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3008016939, 53659, 18175, 159, 56, 222, 199, 117, 75, 185, 231)]
  internal interface IManipulationCompletedEventArgs
  {
    PointerDeviceType PointerDeviceType { get; }

    Point Position { get; }

    ManipulationDelta Cumulative { get; }

    ManipulationVelocities Velocities { get; }
  }
}
