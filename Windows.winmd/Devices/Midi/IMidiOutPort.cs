// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiOutPort
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Midi
{
  [Guid(2468179359, 22434, 19002, 173, 184, 70, 64, 136, 111, 102, 147)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IMidiOutPort : IClosable
  {
    void SendMessage(IMidiMessage midiMessage);

    void SendBuffer(IBuffer midiData);

    string DeviceId { get; }
  }
}
