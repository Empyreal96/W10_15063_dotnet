// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IManipulationUpdatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ExclusiveTo(typeof (ManipulationUpdatedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3409267941, 43960, 20383, 179, 206, 129, 129, 170, 97, 173, 130)]
  internal interface IManipulationUpdatedEventArgs
  {
    PointerDeviceType PointerDeviceType { get; }

    Point Position { get; }

    ManipulationDelta Delta { get; }

    ManipulationDelta Cumulative { get; }

    ManipulationVelocities Velocities { get; }
  }
}
