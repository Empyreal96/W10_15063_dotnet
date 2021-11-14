// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiSongSelectMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MidiSongSelectMessage))]
  [Guid(1240527487, 28035, 18241, 165, 191, 70, 41, 246, 190, 151, 79)]
  internal interface IMidiSongSelectMessage : IMidiMessage
  {
    byte Song { get; }
  }
}
