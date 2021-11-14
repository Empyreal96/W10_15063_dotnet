// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiTimeCodeMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(200738941, 64099, 18972, 141, 235, 192, 232, 119, 150, 166, 215)]
  [ExclusiveTo(typeof (MidiTimeCodeMessage))]
  internal interface IMidiTimeCodeMessage : IMidiMessage
  {
    byte FrameType { get; }

    byte Values { get; }
  }
}
