// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiNoteOffMessageFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ExclusiveTo(typeof (MidiNoteOffMessage))]
  [Guid(2796699872, 42825, 16991, 138, 244, 164, 217, 121, 204, 21, 181)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMidiNoteOffMessageFactory
  {
    MidiNoteOffMessage CreateMidiNoteOffMessage(
      byte channel,
      byte note,
      byte velocity);
  }
}
