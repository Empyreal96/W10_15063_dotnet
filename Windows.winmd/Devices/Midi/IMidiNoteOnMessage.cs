// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiNoteOnMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ExclusiveTo(typeof (MidiNoteOnMessage))]
  [Guid(3760343797, 24961, 18141, 175, 162, 65, 0, 4, 192, 87, 170)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMidiNoteOnMessage : IMidiMessage
  {
    byte Channel { get; }

    byte Note { get; }

    byte Velocity { get; }
  }
}
