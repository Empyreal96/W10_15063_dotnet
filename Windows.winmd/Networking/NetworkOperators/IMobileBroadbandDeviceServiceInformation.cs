// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandDeviceServiceInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (MobileBroadbandDeviceServiceInformation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1406573403, 50413, 17904, 128, 58, 217, 65, 122, 109, 152, 70)]
  internal interface IMobileBroadbandDeviceServiceInformation
  {
    Guid DeviceServiceId { get; }

    bool IsDataReadSupported { get; }

    bool IsDataWriteSupported { get; }
  }
}
