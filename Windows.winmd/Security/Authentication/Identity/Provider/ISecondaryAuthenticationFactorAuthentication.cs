// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.ISecondaryAuthenticationFactorAuthentication
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Authentication.Identity.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(34215653, 27173, 16547, 140, 0, 80, 160, 35, 246, 25, 209)]
  [ExclusiveTo(typeof (SecondaryAuthenticationFactorAuthentication))]
  internal interface ISecondaryAuthenticationFactorAuthentication
  {
    IBuffer ServiceAuthenticationHmac { get; }

    IBuffer SessionNonce { get; }

    IBuffer DeviceNonce { get; }

    IBuffer DeviceConfigurationData { get; }

    [RemoteAsync]
    IAsyncOperation<SecondaryAuthenticationFactorFinishAuthenticationStatus> FinishAuthenticationAsync(
      IBuffer deviceHmac,
      IBuffer sessionHmac);

    [RemoteAsync]
    IAsyncAction AbortAuthenticationAsync(string errorLogMessage);
  }
}
