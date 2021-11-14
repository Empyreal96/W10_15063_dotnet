// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiInPortStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [Guid(1153710556, 26623, 19054, 139, 172, 253, 182, 97, 12, 242, 150)]
  [ExclusiveTo(typeof (MidiInPort))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMidiInPortStatics
  {
    [RemoteAsync]
    IAsyncOperation<MidiInPort> FromIdAsync(string deviceId);

    string GetDeviceSelector();
  }
}
