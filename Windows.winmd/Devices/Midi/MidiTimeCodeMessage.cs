// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.MidiTimeCodeMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Midi
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Activatable(typeof (IMidiTimeCodeMessageFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class MidiTimeCodeMessage : IMidiTimeCodeMessage, IMidiMessage
  {
    [MethodImpl]
    public extern MidiTimeCodeMessage(byte frameType, byte values);

    public extern byte FrameType { [MethodImpl] get; }

    public extern byte Values { [MethodImpl] get; }

    public extern TimeSpan Timestamp { [MethodImpl] get; }

    public extern IBuffer RawData { [MethodImpl] get; }

    public extern MidiMessageType Type { [MethodImpl] get; }
  }
}
