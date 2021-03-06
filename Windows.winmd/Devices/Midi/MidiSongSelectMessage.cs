// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.MidiSongSelectMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Midi
{
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IMidiSongSelectMessageFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MidiSongSelectMessage : IMidiSongSelectMessage, IMidiMessage
  {
    [MethodImpl]
    public extern MidiSongSelectMessage(byte song);

    public extern byte Song { [MethodImpl] get; }

    public extern TimeSpan Timestamp { [MethodImpl] get; }

    public extern IBuffer RawData { [MethodImpl] get; }

    public extern MidiMessageType Type { [MethodImpl] get; }
  }
}
