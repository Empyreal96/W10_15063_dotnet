// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IWhiteBalanceControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ExclusiveTo(typeof (WhiteBalanceControl))]
  [Guid(2015298686, 29026, 18888, 168, 249, 148, 129, 197, 101, 54, 62)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWhiteBalanceControl
  {
    bool Supported { get; }

    ColorTemperaturePreset Preset { get; }

    [RemoteAsync]
    IAsyncAction SetPresetAsync(ColorTemperaturePreset preset);

    uint Min { get; }

    uint Max { get; }

    uint Step { get; }

    uint Value { get; }

    [RemoteAsync]
    IAsyncAction SetValueAsync(uint temperature);
  }
}
