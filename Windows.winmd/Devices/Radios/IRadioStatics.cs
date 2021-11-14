// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Radios.IRadioStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Radios
{
  [ExclusiveTo(typeof (Radio))]
  [Guid(1605804334, 26571, 18094, 170, 233, 101, 145, 159, 134, 239, 244)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRadioStatics
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<Radio>> GetRadiosAsync();

    string GetDeviceSelector();

    [RemoteAsync]
    [Overload("FromIdAsync")]
    IAsyncOperation<Radio> FromIdAsync(string deviceId);

    [RemoteAsync]
    IAsyncOperation<RadioAccessStatus> RequestAccessAsync();
  }
}
