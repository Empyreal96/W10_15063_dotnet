// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IPedometerReading
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (PedometerReading))]
  [Guid(575003892, 43233, 17199, 137, 106, 190, 13, 217, 176, 45, 36)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPedometerReading
  {
    PedometerStepKind StepKind { get; }

    int CumulativeSteps { get; }

    DateTime Timestamp { get; }

    TimeSpan CumulativeStepsDuration { get; }
  }
}
