﻿// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandDeviceServiceDataSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.NetworkOperators
{
  [Guid(3671466803, 35791, 17033, 138, 55, 4, 92, 33, 105, 72, 106)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MobileBroadbandDeviceServiceDataSession))]
  internal interface IMobileBroadbandDeviceServiceDataSession
  {
    [RemoteAsync]
    IAsyncAction WriteDataAsync(IBuffer value);

    void CloseSession();

    event TypedEventHandler<MobileBroadbandDeviceServiceDataSession, MobileBroadbandDeviceServiceDataReceivedEventArgs> DataReceived;
  }
}
