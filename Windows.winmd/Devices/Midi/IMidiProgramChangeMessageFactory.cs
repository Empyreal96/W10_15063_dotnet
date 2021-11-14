// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiProgramChangeMessageFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [Guid(3601875847, 21067, 16644, 156, 153, 101, 114, 191, 210, 226, 97)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MidiProgramChangeMessage))]
  internal interface IMidiProgramChangeMessageFactory
  {
    MidiProgramChangeMessage CreateMidiProgramChangeMessage(
      byte channel,
      byte program);
  }
}
