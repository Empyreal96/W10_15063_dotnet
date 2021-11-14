// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiChannelPressureMessageFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [Guid(1645800751, 8836, 16682, 148, 207, 16, 251, 4, 132, 44, 108)]
  [ExclusiveTo(typeof (MidiChannelPressureMessage))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMidiChannelPressureMessageFactory
  {
    MidiChannelPressureMessage CreateMidiChannelPressureMessage(
      byte channel,
      byte pressure);
  }
}
