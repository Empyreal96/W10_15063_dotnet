// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Media.Devices.AudioRoutingManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Media.Devices
{
  [Static(typeof (IAudioRoutingManagerStatics), 65536, "Windows.Phone.PhoneContract")]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AudioRoutingManager : IAudioRoutingManager
  {
    [MethodImpl]
    public extern AudioRoutingEndpoint GetAudioEndpoint();

    [MethodImpl]
    public extern void SetAudioEndpoint(AudioRoutingEndpoint endpoint);

    public extern event TypedEventHandler<AudioRoutingManager, object> AudioEndpointChanged;

    public extern AvailableAudioRoutingEndpoints AvailableAudioEndpoints { [MethodImpl] get; }

    [MethodImpl]
    public static extern AudioRoutingManager GetDefault();
  }
}
