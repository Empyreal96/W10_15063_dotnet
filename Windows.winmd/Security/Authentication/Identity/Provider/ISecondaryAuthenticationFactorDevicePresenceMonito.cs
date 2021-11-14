// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.ISecondaryAuthenticationFactorDevicePresenceMonitoringRegistrationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Authentication.Identity.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2420742681, 32498, 17699, 149, 28, 164, 23, 162, 74, 207, 147)]
  [ExclusiveTo(typeof (SecondaryAuthenticationFactorRegistration))]
  internal interface ISecondaryAuthenticationFactorDevicePresenceMonitoringRegistrationStatics
  {
    [Overload("RegisterDevicePresenceMonitoringAsync")]
    [RemoteAsync]
    IAsyncOperation<SecondaryAuthenticationFactorDevicePresenceMonitoringRegistrationStatus> RegisterDevicePresenceMonitoringAsync(
      string deviceId,
      string deviceInstancePath,
      SecondaryAuthenticationFactorDevicePresenceMonitoringMode monitoringMode);

    [Overload("RegisterDevicePresenceMonitoringWithNewDeviceAsync")]
    [RemoteAsync]
    IAsyncOperation<SecondaryAuthenticationFactorDevicePresenceMonitoringRegistrationStatus> RegisterDevicePresenceMonitoringAsync(
      string deviceId,
      string deviceInstancePath,
      SecondaryAuthenticationFactorDevicePresenceMonitoringMode monitoringMode,
      string deviceFriendlyName,
      string deviceModelNumber,
      IBuffer deviceConfigurationData);

    [RemoteAsync]
    IAsyncAction UnregisterDevicePresenceMonitoringAsync(string deviceId);

    bool IsDevicePresenceMonitoringSupported();
  }
}
