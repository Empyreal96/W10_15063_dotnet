// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.MidiPolyphonicKeyPressureMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Midi
{
  [Activatable(typeof (IMidiPolyphonicKeyPressureMessageFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class MidiPolyphonicKeyPressureMessage : 
    IMidiPolyphonicKeyPressureMessage,
    IMidiMessage
  {
    [MethodImpl]
    public extern MidiPolyphonicKeyPressureMessage(byte channel, byte note, byte pressure);

    public extern byte Channel { [MethodImpl] get; }

    public extern byte Note { [MethodImpl] get; }

    public extern byte Pressure { [MethodImpl] get; }

    public extern TimeSpan Timestamp { [MethodImpl] get; }

    public extern IBuffer RawData { [MethodImpl] get; }

    public extern MidiMessageType Type { [MethodImpl] get; }
  }
}
