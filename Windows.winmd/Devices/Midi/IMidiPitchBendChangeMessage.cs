// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiPitchBendChangeMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MidiPitchBendChangeMessage))]
  [Guid(702500017, 11935, 20399, 140, 43, 156, 184, 42, 144, 121, 202)]
  internal interface IMidiPitchBendChangeMessage : IMidiMessage
  {
    byte Channel { get; }

    ushort Bend { get; }
  }
}
