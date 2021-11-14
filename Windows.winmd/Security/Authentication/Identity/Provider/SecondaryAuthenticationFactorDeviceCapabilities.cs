// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorDeviceCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Flags]
  public enum SecondaryAuthenticationFactorDeviceCapabilities : uint
  {
    None = 0,
    SecureStorage = 1,
    StoreKeys = 2,
    ConfirmUserIntentToAuthenticate = 4,
    SupportSecureUserPresenceCheck = 8,
    TransmittedDataIsEncrypted = 16, // 0x00000010
    HMacSha256 = 32, // 0x00000020
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] CloseRangeDataTransmission = 64, // 0x00000040
  }
}
