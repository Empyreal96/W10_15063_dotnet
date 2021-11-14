// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyServiceRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [Guid(2343381046, 42755, 17830, 161, 128, 118, 243, 86, 90, 167, 37)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IPlayReadyServiceRequest : IMediaProtectionServiceRequest
  {
    Uri Uri { get; set; }

    string ResponseCustomData { get; }

    string ChallengeCustomData { get; set; }

    [RemoteAsync]
    IAsyncAction BeginServiceRequest();

    IPlayReadyServiceRequest NextServiceRequest();

    PlayReadySoapMessage GenerateManualEnablingChallenge();

    HResult ProcessManualEnablingResponse([Range(0, 2147483647)] byte[] responseBytes);
  }
}
