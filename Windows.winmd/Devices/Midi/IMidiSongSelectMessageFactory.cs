// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiSongSelectMessageFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [Guid(2223536356, 34632, 16681, 166, 108, 160, 84, 147, 247, 93, 170)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MidiSongSelectMessage))]
  internal interface IMidiSongSelectMessageFactory
  {
    MidiSongSelectMessage CreateMidiSongSelectMessage(byte song);
  }
}
