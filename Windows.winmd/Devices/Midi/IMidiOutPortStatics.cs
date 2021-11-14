// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiOutPortStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MidiOutPort))]
  [Guid(106742761, 3976, 17547, 155, 100, 169, 88, 38, 198, 91, 143)]
  internal interface IMidiOutPortStatics
  {
    [RemoteAsync]
    IAsyncOperation<IMidiOutPort> FromIdAsync(string deviceId);

    string GetDeviceSelector();
  }
}
