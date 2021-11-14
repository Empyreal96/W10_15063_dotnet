// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.UI.UserConsentVerifier
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials.UI
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IUserConsentVerifierStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class UserConsentVerifier
  {
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<UserConsentVerifierAvailability> CheckAvailabilityAsync();

    [MethodImpl]
    public static extern IAsyncOperation<UserConsentVerificationResult> RequestVerificationAsync(
      string message);
  }
}
