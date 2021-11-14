// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Media.Devices.IAudioRoutingManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Media.Devices
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Guid(2033454368, 29132, 17702, 159, 41, 252, 141, 36, 134, 65, 139)]
  [ExclusiveTo(typeof (AudioRoutingManager))]
  internal interface IAudioRoutingManager
  {
    AudioRoutingEndpoint GetAudioEndpoint();

    void SetAudioEndpoint(AudioRoutingEndpoint endpoint);

    event TypedEventHandler<AudioRoutingManager, object> AudioEndpointChanged;

    AvailableAudioRoutingEndpoints AvailableAudioEndpoints { get; }
  }
}
