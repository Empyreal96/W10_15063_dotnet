// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.MidiInPort
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IMidiInPortStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MidiInPort : IMidiInPort, IClosable
  {
    public extern event TypedEventHandler<MidiInPort, MidiMessageReceivedEventArgs> MessageReceived;

    public extern string DeviceId { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MidiInPort> FromIdAsync(
      string deviceId);

    [MethodImpl]
    public static extern string GetDeviceSelector();
  }
}
