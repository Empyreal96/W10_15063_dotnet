// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiPolyphonicKeyPressureMessageFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ExclusiveTo(typeof (MidiPolyphonicKeyPressureMessage))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3918481470, 50355, 19922, 145, 124, 227, 73, 129, 90, 27, 59)]
  internal interface IMidiPolyphonicKeyPressureMessageFactory
  {
    MidiPolyphonicKeyPressureMessage CreateMidiPolyphonicKeyPressureMessage(
      byte channel,
      byte note,
      byte pressure);
  }
}
