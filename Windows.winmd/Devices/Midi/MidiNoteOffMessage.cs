// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.MidiNoteOffMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Midi
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IMidiNoteOffMessageFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class MidiNoteOffMessage : IMidiNoteOffMessage, IMidiMessage
  {
    [MethodImpl]
    public extern MidiNoteOffMessage(byte channel, byte note, byte velocity);

    public extern byte Channel { [MethodImpl] get; }

    public extern byte Note { [MethodImpl] get; }

    public extern byte Velocity { [MethodImpl] get; }

    public extern TimeSpan Timestamp { [MethodImpl] get; }

    public extern IBuffer RawData { [MethodImpl] get; }

    public extern MidiMessageType Type { [MethodImpl] get; }
  }
}
