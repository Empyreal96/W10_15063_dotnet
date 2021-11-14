// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.PlayReadyStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPlayReadyStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPlayReadyStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPlayReadyStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPlayReadyStatics4), 196608, "Windows.Foundation.UniversalApiContract")]
  public static class PlayReadyStatics
  {
    public static extern string InputTrustAuthorityToCreate { [MethodImpl] get; }

    public static extern Guid ProtectionSystemId { [MethodImpl] get; }

    public static extern Guid SecureStopServiceRequestType { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool CheckSupportedHardware(PlayReadyHardwareDRMFeatures hwdrmFeature);

    public static extern uint PlayReadyCertificateSecurityLevel { [MethodImpl] get; }

    public static extern Guid DomainJoinServiceRequestType { [MethodImpl] get; }

    public static extern Guid DomainLeaveServiceRequestType { [MethodImpl] get; }

    public static extern Guid IndividualizationServiceRequestType { [MethodImpl] get; }

    public static extern Guid LicenseAcquirerServiceRequestType { [MethodImpl] get; }

    public static extern Guid MeteringReportServiceRequestType { [MethodImpl] get; }

    public static extern Guid RevocationServiceRequestType { [MethodImpl] get; }

    public static extern Guid MediaProtectionSystemId { [MethodImpl] get; }

    public static extern uint PlayReadySecurityVersion { [MethodImpl] get; }
  }
}
