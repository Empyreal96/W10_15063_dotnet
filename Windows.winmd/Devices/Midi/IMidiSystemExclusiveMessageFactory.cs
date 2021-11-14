// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiSystemExclusiveMessageFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Midi
{
  [ExclusiveTo(typeof (MidiSystemExclusiveMessage))]
  [Guid(138273314, 15220, 17184, 155, 66, 12, 168, 84, 95, 138, 36)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMidiSystemExclusiveMessageFactory
  {
    MidiSystemExclusiveMessage CreateMidiSystemExclusiveMessage(
      IBuffer rawData);
  }
}
