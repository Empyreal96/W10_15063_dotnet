// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiProgramChangeMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ExclusiveTo(typeof (MidiProgramChangeMessage))]
  [Guid(2629516408, 31294, 17191, 170, 152, 32, 184, 228, 72, 90, 248)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMidiProgramChangeMessage : IMidiMessage
  {
    byte Channel { get; }

    byte Program { get; }
  }
}
