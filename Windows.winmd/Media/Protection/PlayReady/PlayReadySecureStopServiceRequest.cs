// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.PlayReadySecureStopServiceRequest
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
  [Activatable(typeof (IPlayReadySecureStopServiceRequestFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class PlayReadySecureStopServiceRequest : 
    IPlayReadySecureStopServiceRequest,
    IPlayReadyServiceRequest,
    IMediaProtectionServiceRequest
  {
    [MethodImpl]
    public extern PlayReadySecureStopServiceRequest([Range(0, 2147483647)] byte[] publisherCertBytes);

    [MethodImpl]
    public extern PlayReadySecureStopServiceRequest(Guid sessionID, [Range(0, 2147483647)] byte[] publisherCertBytes);

    public extern Guid SessionID { [MethodImpl] get; }

    public extern global::Windows.Foundation.DateTime StartTime { [MethodImpl] get; }

    public extern global::Windows.Foundation.DateTime UpdateTime { [MethodImpl] get; }

    public extern bool Stopped { [MethodImpl] get; }

    public extern byte[] PublisherCertificate { [MethodImpl] get; }

    public extern global::Windows.Foundation.Uri Uri { [MethodImpl] get; [MethodImpl] set; }

    public extern string ResponseCustomData { [MethodImpl] get; }

    public extern string ChallengeCustomData { [MethodImpl] get; [MethodImpl] set; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction BeginServiceRequest();

    [MethodImpl]
    public extern IPlayReadyServiceRequest NextServiceRequest();

    [MethodImpl]
    public extern PlayReadySoapMessage GenerateManualEnablingChallenge();

    [MethodImpl]
    public extern HResult ProcessManualEnablingResponse([Range(0, 2147483647)] byte[] responseBytes);

    public extern Guid ProtectionSystem { [MethodImpl] get; }

    public extern Guid Type { [MethodImpl] get; }
  }
}
