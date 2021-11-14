// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardCryptogramStorageKeyInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (SmartCardEmulatorContract), 131072)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SmartCardCryptogramStorageKeyInfo : 
    ISmartCardCryptogramStorageKeyInfo,
    ISmartCardCryptogramStorageKeyInfo2
  {
    public extern SmartCardCryptogramGeneratorOperationStatus OperationStatus { [MethodImpl] get; }

    public extern CryptographicPublicKeyBlobType PublicKeyBlobType { [MethodImpl] get; }

    public extern IBuffer PublicKey { [MethodImpl] get; }

    public extern SmartCardCryptographicKeyAttestationStatus AttestationStatus { [MethodImpl] get; }

    public extern IBuffer Attestation { [MethodImpl] get; }

    public extern IBuffer AttestationCertificateChain { [MethodImpl] get; }

    public extern SmartCardCryptogramStorageKeyCapabilities Capabilities { [MethodImpl] get; }

    public extern string OperationalRequirements { [MethodImpl] get; }
  }
}
