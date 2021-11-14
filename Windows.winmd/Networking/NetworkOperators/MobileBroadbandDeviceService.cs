// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandDeviceService
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MobileBroadbandDeviceService : IMobileBroadbandDeviceService
  {
    public extern Guid DeviceServiceId { [MethodImpl] get; }

    public extern IVectorView<uint> SupportedCommands { [MethodImpl] get; }

    [MethodImpl]
    public extern MobileBroadbandDeviceServiceDataSession OpenDataSession();

    [MethodImpl]
    public extern MobileBroadbandDeviceServiceCommandSession OpenCommandSession();
  }
}
