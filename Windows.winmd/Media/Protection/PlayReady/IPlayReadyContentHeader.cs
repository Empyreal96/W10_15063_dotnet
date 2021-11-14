// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyContentHeader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2588117610, 32588, 17710, 136, 189, 1, 72, 198, 56, 122, 44)]
  [ExclusiveTo(typeof (PlayReadyContentHeader))]
  internal interface IPlayReadyContentHeader
  {
    Guid KeyId { get; }

    string KeyIdString { get; }

    global::Windows.Foundation.Uri LicenseAcquisitionUrl { get; }

    global::Windows.Foundation.Uri LicenseAcquisitionUserInterfaceUrl { get; }

    Guid DomainServiceId { get; }

    PlayReadyEncryptionAlgorithm EncryptionType { get; }

    string CustomAttributes { get; }

    PlayReadyDecryptorSetup DecryptorSetup { get; }

    byte[] GetSerializedHeader();

    PlayReadyContentHeader HeaderWithEmbeddedUpdates { get; }
  }
}
