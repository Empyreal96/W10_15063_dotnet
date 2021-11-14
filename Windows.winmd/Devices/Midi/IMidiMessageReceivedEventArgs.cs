// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiMessageReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MidiMessageReceivedEventArgs))]
  [Guid(1985375830, 62248, 19281, 144, 125, 179, 168, 206, 150, 191, 128)]
  internal interface IMidiMessageReceivedEventArgs
  {
    IMidiMessage Message { get; }
  }
}
