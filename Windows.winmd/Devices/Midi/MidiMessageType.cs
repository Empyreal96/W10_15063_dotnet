// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.MidiMessageType
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MidiMessageType
  {
    None = 0,
    NoteOff = 128, // 0x00000080
    NoteOn = 144, // 0x00000090
    PolyphonicKeyPressure = 160, // 0x000000A0
    ControlChange = 176, // 0x000000B0
    ProgramChange = 192, // 0x000000C0
    ChannelPressure = 208, // 0x000000D0
    PitchBendChange = 224, // 0x000000E0
    SystemExclusive = 240, // 0x000000F0
    MidiTimeCode = 241, // 0x000000F1
    SongPositionPointer = 242, // 0x000000F2
    SongSelect = 243, // 0x000000F3
    TuneRequest = 246, // 0x000000F6
    EndSystemExclusive = 247, // 0x000000F7
    TimingClock = 248, // 0x000000F8
    Start = 250, // 0x000000FA
    Continue = 251, // 0x000000FB
    Stop = 252, // 0x000000FC
    ActiveSensing = 254, // 0x000000FE
    SystemReset = 255, // 0x000000FF
  }
}
