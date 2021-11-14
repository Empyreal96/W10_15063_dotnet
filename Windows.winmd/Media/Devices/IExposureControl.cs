// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IExposureControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ExclusiveTo(typeof (ExposureControl))]
  [Guid(166251490, 44438, 20264, 160, 224, 150, 237, 126, 27, 95, 210)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IExposureControl
  {
    bool Supported { get; }

    bool Auto { get; }

    [RemoteAsync]
    IAsyncAction SetAutoAsync(bool value);

    TimeSpan Min { get; }

    TimeSpan Max { get; }

    TimeSpan Step { get; }

    TimeSpan Value { get; }

    [RemoteAsync]
    IAsyncAction SetValueAsync(TimeSpan shutterDuration);
  }
}
