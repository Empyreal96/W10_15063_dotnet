// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.MidiOutPort
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
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IMidiOutPortStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class MidiOutPort : IMidiOutPort, IClosable
  {
    [MethodImpl]
    public extern void SendMessage(IMidiMessage midiMessage);

    [MethodImpl]
    public extern void SendBuffer(IBuffer midiData);

    public extern string DeviceId { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IMidiOutPort> FromIdAsync(
      string deviceId);

    [MethodImpl]
    public static extern string GetDeviceSelector();
  }
}
