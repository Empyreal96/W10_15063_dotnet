// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiSynthesizer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [Guid(4040824158, 56208, 16479, 184, 174, 33, 210, 225, 127, 46, 69)]
  [ExclusiveTo(typeof (MidiSynthesizer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMidiSynthesizer : IMidiOutPort, IClosable
  {
    DeviceInformation AudioDevice { get; }

    double Volume { get; set; }
  }
}
