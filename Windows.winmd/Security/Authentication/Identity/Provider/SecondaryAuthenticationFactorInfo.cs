// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Authentication.Identity.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772162)]
  public sealed class SecondaryAuthenticationFactorInfo : 
    ISecondaryAuthenticationFactorInfo,
    ISecondaryAuthenticationFactorInfo2
  {
    public extern string DeviceId { [MethodImpl] get; }

    public extern string DeviceFriendlyName { [MethodImpl] get; }

    public extern string DeviceModelNumber { [MethodImpl] get; }

    public extern IBuffer DeviceConfigurationData { [MethodImpl] get; }

    public extern SecondaryAuthenticationFactorDevicePresenceMonitoringMode PresenceMonitoringMode { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction UpdateDevicePresenceAsync(
      SecondaryAuthenticationFactorDevicePresence presenceState);

    public extern bool IsAuthenticationSupported { [MethodImpl] get; }
  }
}
