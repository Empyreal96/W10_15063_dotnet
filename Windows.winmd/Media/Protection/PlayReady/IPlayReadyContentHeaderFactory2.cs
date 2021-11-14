// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyContentHeaderFactory2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [Guid(3508772085, 44653, 18296, 151, 253, 110, 58, 46, 234, 219, 235)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PlayReadyContentHeader))]
  internal interface IPlayReadyContentHeaderFactory2
  {
    PlayReadyContentHeader CreateInstanceFromComponents2(
      uint dwFlags,
      [Range(0, 2147483647)] Guid[] contentKeyIds,
      [Range(0, 2147483647)] string[] contentKeyIdStrings,
      PlayReadyEncryptionAlgorithm contentEncryptionAlgorithm,
      global::Windows.Foundation.Uri licenseAcquisitionUrl,
      global::Windows.Foundation.Uri licenseAcquisitionUserInterfaceUrl,
      string customAttributes,
      Guid domainServiceId);
  }
}
