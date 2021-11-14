// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Midi
{
  [Guid(2037807429, 4244, 17027, 155, 224, 40, 159, 192, 238, 131, 52)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IMidiMessage
  {
    TimeSpan Timestamp { get; }

    IBuffer RawData { get; }

    MidiMessageType Type { get; }
  }
}
