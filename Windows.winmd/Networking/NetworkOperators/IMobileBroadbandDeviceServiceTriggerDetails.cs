// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandDeviceServiceTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (MobileBroadbandDeviceServiceTriggerDetails))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1241865072, 47534, 17496, 146, 65, 166, 165, 251, 241, 138, 12)]
  internal interface IMobileBroadbandDeviceServiceTriggerDetails
  {
    string DeviceId { get; }

    Guid DeviceServiceId { get; }

    IBuffer ReceivedData { get; }
  }
}
