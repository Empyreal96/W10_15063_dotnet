// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.IHidDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.HumanInterfaceDevice
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1602884839, 8704, 17198, 149, 218, 208, 155, 135, 213, 116, 168)]
  [ExclusiveTo(typeof (HidDevice))]
  internal interface IHidDevice : IClosable
  {
    ushort VendorId { get; }

    ushort ProductId { get; }

    ushort Version { get; }

    ushort UsagePage { get; }

    ushort UsageId { get; }

    [Overload("GetInputReportAsync")]
    [RemoteAsync]
    IAsyncOperation<HidInputReport> GetInputReportAsync();

    [RemoteAsync]
    [Overload("GetInputReportByIdAsync")]
    IAsyncOperation<HidInputReport> GetInputReportAsync(ushort reportId);

    [RemoteAsync]
    [Overload("GetFeatureReportAsync")]
    IAsyncOperation<HidFeatureReport> GetFeatureReportAsync();

    [Overload("GetFeatureReportByIdAsync")]
    [RemoteAsync]
    IAsyncOperation<HidFeatureReport> GetFeatureReportAsync(
      ushort reportId);

    [Overload("CreateOutputReport")]
    HidOutputReport CreateOutputReport();

    [Overload("CreateOutputReportById")]
    HidOutputReport CreateOutputReport(ushort reportId);

    [Overload("CreateFeatureReport")]
    HidFeatureReport CreateFeatureReport();

    [Overload("CreateFeatureReportById")]
    HidFeatureReport CreateFeatureReport(ushort reportId);

    IAsyncOperation<uint> SendOutputReportAsync(HidOutputReport outputReport);

    IAsyncOperation<uint> SendFeatureReportAsync(HidFeatureReport featureReport);

    IVectorView<HidBooleanControlDescription> GetBooleanControlDescriptions(
      HidReportType reportType,
      ushort usagePage,
      ushort usageId);

    IVectorView<HidNumericControlDescription> GetNumericControlDescriptions(
      HidReportType reportType,
      ushort usagePage,
      ushort usageId);

    event TypedEventHandler<HidDevice, HidInputReportReceivedEventArgs> InputReportReceived;
  }
}
