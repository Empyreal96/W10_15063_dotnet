// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IIsoSpeedControl2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [Guid(1863678194, 28023, 20362, 140, 47, 97, 48, 182, 57, 80, 83)]
  [ExclusiveTo(typeof (IsoSpeedControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IIsoSpeedControl2
  {
    uint Min { get; }

    uint Max { get; }

    uint Step { get; }

    uint Value { get; }

    [RemoteAsync]
    IAsyncAction SetValueAsync(uint isoSpeed);

    bool Auto { get; }

    [RemoteAsync]
    IAsyncAction SetAutoAsync();
  }
}
