// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.INetworkAdapter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ExclusiveTo(typeof (NetworkAdapter))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(995372547, 21384, 18796, 168, 163, 175, 253, 57, 174, 194, 230)]
  internal interface INetworkAdapter
  {
    ulong OutboundMaxBitsPerSecond { get; }

    ulong InboundMaxBitsPerSecond { get; }

    uint IanaInterfaceType { get; }

    NetworkItem NetworkItem { get; }

    Guid NetworkAdapterId { get; }

    [RemoteAsync]
    IAsyncOperation<ConnectionProfile> GetConnectedProfileAsync();
  }
}
