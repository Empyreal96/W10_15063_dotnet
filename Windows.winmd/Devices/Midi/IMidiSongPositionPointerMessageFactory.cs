// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiSongPositionPointerMessageFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ExclusiveTo(typeof (MidiSongPositionPointerMessage))]
  [Guid(2617305494, 61707, 20458, 179, 149, 245, 214, 207, 128, 246, 78)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMidiSongPositionPointerMessageFactory
  {
    MidiSongPositionPointerMessage CreateMidiSongPositionPointerMessage(
      ushort beats);
  }
}
