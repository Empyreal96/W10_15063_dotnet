// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.MidiControlChangeMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Midi
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IMidiControlChangeMessageFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class MidiControlChangeMessage : IMidiControlChangeMessage, IMidiMessage
  {
    [MethodImpl]
    public extern MidiControlChangeMessage(byte channel, byte controller, byte controlValue);

    public extern byte Channel { [MethodImpl] get; }

    public extern byte Controller { [MethodImpl] get; }

    public extern byte ControlValue { [MethodImpl] get; }

    public extern TimeSpan Timestamp { [MethodImpl] get; }

    public extern IBuffer RawData { [MethodImpl] get; }

    public extern MidiMessageType Type { [MethodImpl] get; }
  }
}
