// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandDeviceServiceCommandSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (MobileBroadbandDeviceServiceCommandSession))]
  [Guid(4228483653, 37179, 18708, 182, 195, 174, 99, 4, 89, 62, 117)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMobileBroadbandDeviceServiceCommandSession
  {
    [RemoteAsync]
    IAsyncOperation<MobileBroadbandDeviceServiceCommandResult> SendQueryCommandAsync(
      uint commandId,
      IBuffer data);

    [RemoteAsync]
    IAsyncOperation<MobileBroadbandDeviceServiceCommandResult> SendSetCommandAsync(
      uint commandId,
      IBuffer data);

    void CloseSession();
  }
}
