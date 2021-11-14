// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.UI.IUserConsentVerifierStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials.UI
{
  [ExclusiveTo(typeof (UserConsentVerifier))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2941206417, 22092, 19932, 184, 181, 151, 52, 71, 98, 124, 101)]
  internal interface IUserConsentVerifierStatics
  {
    [RemoteAsync]
    IAsyncOperation<UserConsentVerifierAvailability> CheckAvailabilityAsync();

    IAsyncOperation<UserConsentVerificationResult> RequestVerificationAsync(
      string message);
  }
}
