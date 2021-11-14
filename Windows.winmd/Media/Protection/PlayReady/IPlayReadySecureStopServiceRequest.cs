// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadySecureStopServiceRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [Guid(3041926885, 447, 17409, 150, 119, 5, 99, 10, 106, 76, 200)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IPlayReadySecureStopServiceRequest : 
    IPlayReadyServiceRequest,
    IMediaProtectionServiceRequest
  {
    Guid SessionID { get; }

    global::Windows.Foundation.DateTime StartTime { get; }

    global::Windows.Foundation.DateTime UpdateTime { get; }

    bool Stopped { get; }

    byte[] PublisherCertificate { get; }
  }
}
