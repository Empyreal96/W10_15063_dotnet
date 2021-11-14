// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiInPort
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ExclusiveTo(typeof (MidiInPort))]
  [Guid(3586251227, 38682, 20143, 162, 61, 234, 25, 254, 96, 127, 249)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMidiInPort : IClosable
  {
    event TypedEventHandler<MidiInPort, MidiMessageReceivedEventArgs> MessageReceived;

    string DeviceId { get; }
  }
}
