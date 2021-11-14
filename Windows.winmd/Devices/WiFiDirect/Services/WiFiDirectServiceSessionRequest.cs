// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.WiFiDirectServiceSessionRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.WiFiDirect.Services
{
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WiFiDirectServiceSessionRequest : IWiFiDirectServiceSessionRequest, IClosable
  {
    public extern DeviceInformation DeviceInformation { [MethodImpl] get; }

    public extern WiFiDirectServiceProvisioningInfo ProvisioningInfo { [MethodImpl] get; }

    public extern IBuffer SessionInfo { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();
  }
}
