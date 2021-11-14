// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.ISecondaryAuthenticationFactorRegistrationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Authentication.Identity.Provider
{
  [ExclusiveTo(typeof (SecondaryAuthenticationFactorRegistration))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(450826085, 58295, 16725, 153, 127, 183, 86, 239, 101, 190, 186)]
  internal interface ISecondaryAuthenticationFactorRegistrationStatics
  {
    IAsyncOperation<SecondaryAuthenticationFactorRegistrationResult> RequestStartRegisteringDeviceAsync(
      string deviceId,
      SecondaryAuthenticationFactorDeviceCapabilities capabilities,
      string deviceFriendlyName,
      string deviceModelNumber,
      IBuffer deviceKey,
      IBuffer mutualAuthenticationKey);

    [RemoteAsync]
    IAsyncOperation<IVectorView<SecondaryAuthenticationFactorInfo>> FindAllRegisteredDeviceInfoAsync(
      SecondaryAuthenticationFactorDeviceFindScope queryType);

    [RemoteAsync]
    IAsyncAction UnregisterDeviceAsync(string deviceId);

    [RemoteAsync]
    IAsyncAction UpdateDeviceConfigurationDataAsync(
      string deviceId,
      IBuffer deviceConfigurationData);
  }
}
