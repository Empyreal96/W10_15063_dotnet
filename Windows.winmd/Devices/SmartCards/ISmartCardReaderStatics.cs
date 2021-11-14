// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardReaderStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [Guid(272368865, 41418, 18674, 162, 129, 91, 111, 102, 154, 241, 7)]
  [ExclusiveTo(typeof (SmartCardReader))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISmartCardReaderStatics
  {
    [Overload("GetDeviceSelector")]
    string GetDeviceSelector();

    [Overload("GetDeviceSelectorWithKind")]
    string GetDeviceSelector(SmartCardReaderKind kind);

    [RemoteAsync]
    IAsyncOperation<SmartCardReader> FromIdAsync(string deviceId);
  }
}
