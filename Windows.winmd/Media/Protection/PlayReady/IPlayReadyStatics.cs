// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ExclusiveTo(typeof (PlayReadyStatics))]
  [Guid(1583988749, 9340, 18074, 143, 49, 92, 26, 21, 113, 217, 198)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPlayReadyStatics
  {
    Guid DomainJoinServiceRequestType { get; }

    Guid DomainLeaveServiceRequestType { get; }

    Guid IndividualizationServiceRequestType { get; }

    Guid LicenseAcquirerServiceRequestType { get; }

    Guid MeteringReportServiceRequestType { get; }

    Guid RevocationServiceRequestType { get; }

    Guid MediaProtectionSystemId { get; }

    uint PlayReadySecurityVersion { get; }
  }
}
