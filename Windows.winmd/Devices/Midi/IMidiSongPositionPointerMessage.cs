// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiSongPositionPointerMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ExclusiveTo(typeof (MidiSongPositionPointerMessage))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1285885014, 60510, 19172, 161, 21, 136, 220, 87, 204, 43, 121)]
  internal interface IMidiSongPositionPointerMessage : IMidiMessage
  {
    ushort Beats { get; }
  }
}
