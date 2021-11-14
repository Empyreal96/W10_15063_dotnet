// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardCryptogramStorageKeyInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [Guid(2008084493, 45207, 20321, 162, 106, 149, 97, 99, 156, 156, 58)]
  [ContractVersion(typeof (SmartCardEmulatorContract), 131072)]
  [ExclusiveTo(typeof (SmartCardCryptogramStorageKeyInfo))]
  internal interface ISmartCardCryptogramStorageKeyInfo
  {
    SmartCardCryptogramGeneratorOperationStatus OperationStatus { get; }

    CryptographicPublicKeyBlobType PublicKeyBlobType { get; }

    IBuffer PublicKey { get; }

    SmartCardCryptographicKeyAttestationStatus AttestationStatus { get; }

    IBuffer Attestation { get; }

    IBuffer AttestationCertificateChain { get; }

    SmartCardCryptogramStorageKeyCapabilities Capabilities { get; }
  }
}
