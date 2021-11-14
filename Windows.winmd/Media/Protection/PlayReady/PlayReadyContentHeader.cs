// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.PlayReadyContentHeader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [Activatable(typeof (IPlayReadyContentHeaderFactory2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IPlayReadyContentHeaderFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PlayReadyContentHeader : IPlayReadyContentHeader, IPlayReadyContentHeader2
  {
    [MethodImpl]
    public extern PlayReadyContentHeader(
      uint dwFlags,
      [Range(0, 2147483647)] Guid[] contentKeyIds,
      [Range(0, 2147483647)] string[] contentKeyIdStrings,
      PlayReadyEncryptionAlgorithm contentEncryptionAlgorithm,
      global::Windows.Foundation.Uri licenseAcquisitionUrl,
      global::Windows.Foundation.Uri licenseAcquisitionUserInterfaceUrl,
      string customAttributes,
      Guid domainServiceId);

    [MethodImpl]
    public extern PlayReadyContentHeader(
      [Range(0, 2147483647)] byte[] headerBytes,
      global::Windows.Foundation.Uri licenseAcquisitionUrl,
      global::Windows.Foundation.Uri licenseAcquisitionUserInterfaceUrl,
      string customAttributes,
      Guid domainServiceId);

    [MethodImpl]
    public extern PlayReadyContentHeader(
      Guid contentKeyId,
      string contentKeyIdString,
      PlayReadyEncryptionAlgorithm contentEncryptionAlgorithm,
      global::Windows.Foundation.Uri licenseAcquisitionUrl,
      global::Windows.Foundation.Uri licenseAcquisitionUserInterfaceUrl,
      string customAttributes,
      Guid domainServiceId);

    [MethodImpl]
    public extern PlayReadyContentHeader([Range(0, 2147483647)] byte[] headerBytes);

    public extern Guid KeyId { [MethodImpl] get; }

    public extern string KeyIdString { [MethodImpl] get; }

    public extern global::Windows.Foundation.Uri LicenseAcquisitionUrl { [MethodImpl] get; }

    public extern global::Windows.Foundation.Uri LicenseAcquisitionUserInterfaceUrl { [MethodImpl] get; }

    public extern Guid DomainServiceId { [MethodImpl] get; }

    public extern PlayReadyEncryptionAlgorithm EncryptionType { [MethodImpl] get; }

    public extern string CustomAttributes { [MethodImpl] get; }

    public extern PlayReadyDecryptorSetup DecryptorSetup { [MethodImpl] get; }

    [MethodImpl]
    public extern byte[] GetSerializedHeader();

    public extern PlayReadyContentHeader HeaderWithEmbeddedUpdates { [MethodImpl] get; }

    public extern Guid[] KeyIds { [MethodImpl] get; }

    public extern string[] KeyIdStrings { [MethodImpl] get; }
  }
}
