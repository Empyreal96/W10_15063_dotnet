// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IExposureCompensationControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ExclusiveTo(typeof (ExposureCompensationControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2177427508, 56556, 16401, 166, 16, 31, 56, 71, 230, 74, 202)]
  internal interface IExposureCompensationControl
  {
    bool Supported { get; }

    float Min { get; }

    float Max { get; }

    float Step { get; }

    float Value { get; }

    [RemoteAsync]
    IAsyncAction SetValueAsync(float value);
  }
}
