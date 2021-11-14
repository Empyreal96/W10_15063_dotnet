// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.ISecondaryAuthenticationFactorAuthenticationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Authentication.Identity.Provider
{
  [Guid(1062741590, 10488, 19983, 174, 140, 88, 152, 185, 174, 36, 105)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (SecondaryAuthenticationFactorAuthentication))]
  internal interface ISecondaryAuthenticationFactorAuthenticationStatics
  {
    IAsyncAction ShowNotificationMessageAsync(
      string deviceName,
      SecondaryAuthenticationFactorAuthenticationMessage message);

    [RemoteAsync]
    IAsyncOperation<SecondaryAuthenticationFactorAuthenticationResult> StartAuthenticationAsync(
      string deviceId,
      IBuffer serviceAuthenticationNonce);

    event EventHandler<SecondaryAuthenticationFactorAuthenticationStageChangedEventArgs> AuthenticationStageChanged;

    [RemoteAsync]
    IAsyncOperation<SecondaryAuthenticationFactorAuthenticationStageInfo> GetAuthenticationStageInfoAsync();
  }
}
