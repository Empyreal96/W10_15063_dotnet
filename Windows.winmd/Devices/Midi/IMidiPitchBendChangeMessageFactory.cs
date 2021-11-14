// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiPitchBendChangeMessageFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [Guid(4126072661, 53192, 18726, 179, 14, 163, 98, 35, 147, 48, 108)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MidiPitchBendChangeMessage))]
  internal interface IMidiPitchBendChangeMessageFactory
  {
    MidiPitchBendChangeMessage CreateMidiPitchBendChangeMessage(
      byte channel,
      ushort bend);
  }
}
