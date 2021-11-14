// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiNoteOnMessageFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ExclusiveTo(typeof (MidiNoteOnMessage))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2604826784, 22977, 16910, 181, 23, 21, 161, 10, 169, 96, 107)]
  internal interface IMidiNoteOnMessageFactory
  {
    MidiNoteOnMessage CreateMidiNoteOnMessage(
      byte channel,
      byte note,
      byte velocity);
  }
}
