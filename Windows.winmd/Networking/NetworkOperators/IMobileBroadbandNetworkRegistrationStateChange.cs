﻿// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandNetworkRegistrationStateChange
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MobileBroadbandNetworkRegistrationStateChange))]
  [Guid(3199177953, 38415, 18868, 160, 141, 125, 133, 233, 104, 199, 236)]
  internal interface IMobileBroadbandNetworkRegistrationStateChange
  {
    string DeviceId { get; }

    MobileBroadbandNetwork Network { get; }
  }
}
