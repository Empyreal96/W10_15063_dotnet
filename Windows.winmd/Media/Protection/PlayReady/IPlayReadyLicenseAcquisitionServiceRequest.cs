// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyLicenseAcquisitionServiceRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [Guid(1569062725, 16031, 20296, 147, 225, 149, 48, 200, 213, 140, 62)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IPlayReadyLicenseAcquisitionServiceRequest : 
    IPlayReadyServiceRequest,
    IMediaProtectionServiceRequest
  {
    PlayReadyContentHeader ContentHeader { get; set; }

    Guid DomainServiceId { get; set; }
  }
}
