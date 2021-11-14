// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyContentHeaderFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ExclusiveTo(typeof (PlayReadyContentHeader))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3415722239, 46936, 18294, 191, 1, 33, 122, 139, 81, 11, 44)]
  internal interface IPlayReadyContentHeaderFactory
  {
    PlayReadyContentHeader CreateInstanceFromWindowsMediaDrmHeader(
      [Range(0, 2147483647)] byte[] headerBytes,
      global::Windows.Foundation.Uri licenseAcquisitionUrl,
      global::Windows.Foundation.Uri licenseAcquisitionUserInterfaceUrl,
      string customAttributes,
      Guid domainServiceId);

    PlayReadyContentHeader CreateInstanceFromComponents(
      Guid contentKeyId,
      string contentKeyIdString,
      PlayReadyEncryptionAlgorithm contentEncryptionAlgorithm,
      global::Windows.Foundation.Uri licenseAcquisitionUrl,
      global::Windows.Foundation.Uri licenseAcquisitionUserInterfaceUrl,
      string customAttributes,
      Guid domainServiceId);

    PlayReadyContentHeader CreateInstanceFromPlayReadyHeader(
      [Range(0, 2147483647)] byte[] headerBytes);
  }
}
