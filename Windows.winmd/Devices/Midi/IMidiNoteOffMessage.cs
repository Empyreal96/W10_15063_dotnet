// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiNoteOffMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [Guid(385714932, 6542, 19855, 166, 84, 211, 5, 162, 147, 84, 143)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MidiNoteOffMessage))]
  internal interface IMidiNoteOffMessage : IMidiMessage
  {
    byte Channel { get; }

    byte Note { get; }

    byte Velocity { get; }
  }
}
