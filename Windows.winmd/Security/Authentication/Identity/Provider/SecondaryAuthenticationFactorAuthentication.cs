// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorAuthentication
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Authentication.Identity.Provider
{
  [DualApiPartition(version = 167772162)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ISecondaryAuthenticationFactorAuthenticationStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class SecondaryAuthenticationFactorAuthentication : 
    ISecondaryAuthenticationFactorAuthentication
  {
    public extern IBuffer ServiceAuthenticationHmac { [MethodImpl] get; }

    public extern IBuffer SessionNonce { [MethodImpl] get; }

    public extern IBuffer DeviceNonce { [MethodImpl] get; }

    public extern IBuffer DeviceConfigurationData { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SecondaryAuthenticationFactorFinishAuthenticationStatus> FinishAuthenticationAsync(
      IBuffer deviceHmac,
      IBuffer sessionHmac);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction AbortAuthenticationAsync(string errorLogMessage);

    [MethodImpl]
    public static extern IAsyncAction ShowNotificationMessageAsync(
      string deviceName,
      SecondaryAuthenticationFactorAuthenticationMessage message);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<SecondaryAuthenticationFactorAuthenticationResult> StartAuthenticationAsync(
      string deviceId,
      IBuffer serviceAuthenticationNonce);

    public static extern event EventHandler<SecondaryAuthenticationFactorAuthenticationStageChangedEventArgs> AuthenticationStageChanged;

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<SecondaryAuthenticationFactorAuthenticationStageInfo> GetAuthenticationStageInfoAsync();
  }
}
