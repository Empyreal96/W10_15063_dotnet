// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiControlChangeMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MidiControlChangeMessage))]
  [Guid(3085000579, 30733, 16479, 183, 129, 62, 21, 152, 201, 127, 64)]
  internal interface IMidiControlChangeMessage : IMidiMessage
  {
    byte Channel { get; }

    byte Controller { get; }

    byte ControlValue { get; }
  }
}
