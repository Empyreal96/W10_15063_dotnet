// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiTimeCodeMessageFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MidiTimeCodeMessage))]
  [Guid(3945830853, 30492, 16606, 185, 97, 23, 90, 116, 137, 168, 94)]
  internal interface IMidiTimeCodeMessageFactory
  {
    MidiTimeCodeMessage CreateMidiTimeCodeMessage(byte frameType, byte values);
  }
}
