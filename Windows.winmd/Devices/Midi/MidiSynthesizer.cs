// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.MidiSynthesizer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Midi
{
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IMidiSynthesizerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MidiSynthesizer : IMidiSynthesizer, IMidiOutPort, IClosable
  {
    public extern DeviceInformation AudioDevice { [MethodImpl] get; }

    public extern double Volume { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void SendMessage(IMidiMessage midiMessage);

    [MethodImpl]
    public extern void SendBuffer(IBuffer midiData);

    public extern string DeviceId { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    [Overload("CreateAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MidiSynthesizer> CreateAsync();

    [Overload("CreateFromAudioDeviceAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MidiSynthesizer> CreateAsync(
      DeviceInformation audioDevice);

    [MethodImpl]
    public static extern bool IsSynthesizer(DeviceInformation midiDevice);
  }
}
