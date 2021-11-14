// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IRawGameController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Gaming.Input.ForceFeedback;

namespace Windows.Gaming.Input
{
  [Guid(2091740561, 42977, 20337, 154, 120, 51, 233, 197, 223, 234, 98)]
  [ExclusiveTo(typeof (RawGameController))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IRawGameController : IGameController
  {
    int AxisCount { get; }

    int ButtonCount { get; }

    IVectorView<ForceFeedbackMotor> ForceFeedbackMotors { get; }

    ushort HardwareProductId { get; }

    ushort HardwareVendorId { get; }

    int SwitchCount { get; }

    GameControllerButtonLabel GetButtonLabel(int buttonIndex);

    ulong GetCurrentReading(
      [Out] bool[] buttonArray,
      [Out] GameControllerSwitchPosition[] switchArray,
      [Out] double[] axisArray);

    GameControllerSwitchKind GetSwitchKind(int switchIndex);
  }
}
