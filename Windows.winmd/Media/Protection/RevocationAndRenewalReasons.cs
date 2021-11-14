// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.RevocationAndRenewalReasons
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum RevocationAndRenewalReasons : uint
  {
    UserModeComponentLoad = 1,
    KernelModeComponentLoad = 2,
    AppComponent = 4,
    GlobalRevocationListLoadFailed = 16, // 0x00000010
    InvalidGlobalRevocationListSignature = 32, // 0x00000020
    GlobalRevocationListAbsent = 4096, // 0x00001000
    ComponentRevoked = 8192, // 0x00002000
    InvalidComponentCertificateExtendedKeyUse = 16384, // 0x00004000
    ComponentCertificateRevoked = 32768, // 0x00008000
    InvalidComponentCertificateRoot = 65536, // 0x00010000
    ComponentHighSecurityCertificateRevoked = 131072, // 0x00020000
    ComponentLowSecurityCertificateRevoked = 262144, // 0x00040000
    BootDriverVerificationFailed = 1048576, // 0x00100000
    ComponentSignedWithTestCertificate = 16777216, // 0x01000000
    EncryptionFailure = 268435456, // 0x10000000
  }
}
