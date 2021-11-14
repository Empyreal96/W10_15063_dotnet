// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadySecureStopServiceRequestFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(239373001, 59006, 18766, 159, 73, 98, 133, 67, 140, 118, 207)]
  [ExclusiveTo(typeof (PlayReadySecureStopServiceRequest))]
  internal interface IPlayReadySecureStopServiceRequestFactory
  {
    PlayReadySecureStopServiceRequest CreateInstance(
      [Range(0, 2147483647)] byte[] publisherCertBytes);

    PlayReadySecureStopServiceRequest CreateInstanceFromSessionID(
      Guid sessionID,
      [Range(0, 2147483647)] byte[] publisherCertBytes);
  }
}
