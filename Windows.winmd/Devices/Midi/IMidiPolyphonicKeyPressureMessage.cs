// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiPolyphonicKeyPressureMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(527644670, 44264, 18592, 134, 142, 124, 219, 242, 15, 4, 214)]
  [ExclusiveTo(typeof (MidiPolyphonicKeyPressureMessage))]
  internal interface IMidiPolyphonicKeyPressureMessage : IMidiMessage
  {
    byte Channel { get; }

    byte Note { get; }

    byte Pressure { get; }
  }
}
