// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiChannelPressureMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ExclusiveTo(typeof (MidiChannelPressureMessage))]
  [Guid(3189745760, 25268, 19794, 163, 126, 146, 229, 77, 53, 185, 9)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMidiChannelPressureMessage : IMidiMessage
  {
    byte Channel { get; }

    byte Pressure { get; }
  }
}
