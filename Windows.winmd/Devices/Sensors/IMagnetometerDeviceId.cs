﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IMagnetometerDeviceId
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1488230594, 32331, 16460, 159, 197, 93, 232, 180, 14, 186, 227)]
  [ExclusiveTo(typeof (Magnetometer))]
  internal interface IMagnetometerDeviceId
  {
    string DeviceId { get; }
  }
}