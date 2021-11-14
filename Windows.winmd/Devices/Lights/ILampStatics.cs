// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.ILampStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Lights
{
  [Guid(2820817260, 34949, 16414, 184, 33, 142, 139, 56, 168, 232, 236)]
  [ExclusiveTo(typeof (Lamp))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILampStatics
  {
    string GetDeviceSelector();

    [RemoteAsync]
    IAsyncOperation<Lamp> FromIdAsync(string deviceId);

    [RemoteAsync]
    IAsyncOperation<Lamp> GetDefaultAsync();
  }
}
