// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorAuthenticationStage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum SecondaryAuthenticationFactorAuthenticationStage
  {
    NotStarted,
    WaitingForUserConfirmation,
    CollectingCredential,
    SuspendingAuthentication,
    CredentialCollected,
    CredentialAuthenticated,
    StoppingAuthentication,
    ReadyForLock,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] CheckingDevicePresence,
  }
}
