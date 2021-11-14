// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiControlChangeMessageFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [Guid(716260129, 38252, 18093, 151, 82, 248, 127, 85, 5, 47, 227)]
  [ExclusiveTo(typeof (MidiControlChangeMessage))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMidiControlChangeMessageFactory
  {
    MidiControlChangeMessage CreateMidiControlChangeMessage(
      byte channel,
      byte controller,
      byte controlValue);
  }
}
