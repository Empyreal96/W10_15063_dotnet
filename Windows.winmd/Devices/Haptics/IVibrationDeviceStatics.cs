// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Haptics.IVibrationDeviceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Haptics
{
  [Guid(1407380973, 8848, 19145, 142, 179, 26, 132, 18, 46, 183, 28)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (VibrationDevice))]
  internal interface IVibrationDeviceStatics
  {
    [RemoteAsync]
    IAsyncOperation<VibrationAccessStatus> RequestAccessAsync();

    string GetDeviceSelector();

    [RemoteAsync]
    IAsyncOperation<VibrationDevice> FromIdAsync(string deviceId);

    [RemoteAsync]
    IAsyncOperation<VibrationDevice> GetDefaultAsync();

    [RemoteAsync]
    IAsyncOperation<IVectorView<VibrationDevice>> FindAllAsync();
  }
}
