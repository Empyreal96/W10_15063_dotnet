﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IMagnetometerReadingChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (MagnetometerReadingChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(401270898, 11961, 20199, 138, 208, 49, 39, 83, 125, 148, 155)]
  internal interface IMagnetometerReadingChangedEventArgs
  {
    MagnetometerReading Reading { get; }
  }
}
