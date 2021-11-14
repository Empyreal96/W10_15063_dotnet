// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IRacingWheel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Gaming.Input.ForceFeedback;

namespace Windows.Gaming.Input
{
  [ExclusiveTo(typeof (RacingWheel))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(4115031407, 57606, 19586, 169, 15, 85, 64, 18, 144, 75, 133)]
  internal interface IRacingWheel : IGameController
  {
    bool HasClutch { get; }

    bool HasHandbrake { get; }

    bool HasPatternShifter { get; }

    int MaxPatternShifterGear { get; }

    double MaxWheelAngle { get; }

    ForceFeedbackMotor WheelMotor { get; }

    GameControllerButtonLabel GetButtonLabel(RacingWheelButtons button);

    RacingWheelReading GetCurrentReading();
  }
}
