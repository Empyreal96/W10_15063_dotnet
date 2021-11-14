// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorRegistration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Authentication.Identity.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ISecondaryAuthenticationFactorRegistrationStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772162)]
  [Static(typeof (ISecondaryAuthenticationFactorDevicePresenceMonitoringRegistrationStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class SecondaryAuthenticationFactorRegistration : 
    ISecondaryAuthenticationFactorRegistration
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction FinishRegisteringDeviceAsync(
      IBuffer deviceConfigurationData);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction AbortRegisteringDeviceAsync(string errorLogMessage);

    [Overload("RegisterDevicePresenceMonitoringAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<SecondaryAuthenticationFactorDevicePresenceMonitoringRegistrationStatus> RegisterDevicePresenceMonitoringAsync(
      string deviceId,
      string deviceInstancePath,
      SecondaryAuthenticationFactorDevicePresenceMonitoringMode monitoringMode);

    [RemoteAsync]
    [Overload("RegisterDevicePresenceMonitoringWithNewDeviceAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<SecondaryAuthenticationFactorDevicePresenceMonitoringRegistrationStatus> RegisterDevicePresenceMonitoringAsync(
      string deviceId,
      string deviceInstancePath,
      SecondaryAuthenticationFactorDevicePresenceMonitoringMode monitoringMode,
      string deviceFriendlyName,
      string deviceModelNumber,
      IBuffer deviceConfigurationData);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction UnregisterDevicePresenceMonitoringAsync(
      string deviceId);

    [MethodImpl]
    public static extern bool IsDevicePresenceMonitoringSupported();

    [MethodImpl]
    public static extern IAsyncOperation<SecondaryAuthenticationFactorRegistrationResult> RequestStartRegisteringDeviceAsync(
      string deviceId,
      SecondaryAuthenticationFactorDeviceCapabilities capabilities,
      string deviceFriendlyName,
      string deviceModelNumber,
      IBuffer deviceKey,
      IBuffer mutualAuthenticationKey);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<SecondaryAuthenticationFactorInfo>> FindAllRegisteredDeviceInfoAsync(
      SecondaryAuthenticationFactorDeviceFindScope queryType);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction UnregisterDeviceAsync(string deviceId);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction UpdateDeviceConfigurationDataAsync(
      string deviceId,
      IBuffer deviceConfigurationData);
  }
}
