// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyLicenseAcquisitionServiceRequest2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [Guid(3086638773, 65036, 45605, 188, 96, 90, 158, 221, 50, 206, 181)]
  [ExclusiveTo(typeof (PlayReadyLicenseAcquisitionServiceRequest))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IPlayReadyLicenseAcquisitionServiceRequest2 : 
    IPlayReadyLicenseAcquisitionServiceRequest,
    IPlayReadyServiceRequest,
    IMediaProtectionServiceRequest
  {
    Guid SessionId { get; }
  }
}
