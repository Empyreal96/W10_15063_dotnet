// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiSynthesizerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ExclusiveTo(typeof (MidiSynthesizer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1109715624, 26153, 19819, 170, 143, 212, 82, 26, 90, 49, 206)]
  internal interface IMidiSynthesizerStatics
  {
    [RemoteAsync]
    [Overload("CreateAsync")]
    IAsyncOperation<MidiSynthesizer> CreateAsync();

    [RemoteAsync]
    [Overload("CreateFromAudioDeviceAsync")]
    IAsyncOperation<MidiSynthesizer> CreateAsync(
      DeviceInformation audioDevice);

    bool IsSynthesizer(DeviceInformation midiDevice);
  }
}
