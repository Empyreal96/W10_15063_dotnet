﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.MidiTuneRequestMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Midi
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class MidiTuneRequestMessage : IMidiMessage
  {
    [MethodImpl]
    public extern MidiTuneRequestMessage();

    public extern TimeSpan Timestamp { [MethodImpl] get; }

    public extern IBuffer RawData { [MethodImpl] get; }

    public extern MidiMessageType Type { [MethodImpl] get; }
  }
}