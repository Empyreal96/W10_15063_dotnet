// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandDeviceService
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(582883922, 48512, 16556, 142, 31, 46, 7, 131, 106, 61, 189)]
  [ExclusiveTo(typeof (MobileBroadbandDeviceService))]
  internal interface IMobileBroadbandDeviceService
  {
    Guid DeviceServiceId { get; }

    IVectorView<uint> SupportedCommands { get; }

    MobileBroadbandDeviceServiceDataSession OpenDataSession();

    MobileBroadbandDeviceServiceCommandSession OpenCommandSession();
  }
}
