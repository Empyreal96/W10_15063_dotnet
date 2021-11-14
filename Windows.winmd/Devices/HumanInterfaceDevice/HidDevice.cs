// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.HidDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Devices.HumanInterfaceDevice
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  [Static(typeof (IHidDeviceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class HidDevice : IHidDevice, IClosable
  {
    public extern ushort VendorId { [MethodImpl] get; }

    public extern ushort ProductId { [MethodImpl] get; }

    public extern ushort Version { [MethodImpl] get; }

    public extern ushort UsagePage { [MethodImpl] get; }

    public extern ushort UsageId { [MethodImpl] get; }

    [RemoteAsync]
    [Overload("GetInputReportAsync")]
    [MethodImpl]
    public extern IAsyncOperation<HidInputReport> GetInputReportAsync();

    [RemoteAsync]
    [Overload("GetInputReportByIdAsync")]
    [MethodImpl]
    public extern IAsyncOperation<HidInputReport> GetInputReportAsync(
      ushort reportId);

    [Overload("GetFeatureReportAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<HidFeatureReport> GetFeatureReportAsync();

    [RemoteAsync]
    [Overload("GetFeatureReportByIdAsync")]
    [MethodImpl]
    public extern IAsyncOperation<HidFeatureReport> GetFeatureReportAsync(
      ushort reportId);

    [Overload("CreateOutputReport")]
    [MethodImpl]
    public extern HidOutputReport CreateOutputReport();

    [Overload("CreateOutputReportById")]
    [MethodImpl]
    public extern HidOutputReport CreateOutputReport(ushort reportId);

    [Overload("CreateFeatureReport")]
    [MethodImpl]
    public extern HidFeatureReport CreateFeatureReport();

    [Overload("CreateFeatureReportById")]
    [MethodImpl]
    public extern HidFeatureReport CreateFeatureReport(ushort reportId);

    [MethodImpl]
    public extern IAsyncOperation<uint> SendOutputReportAsync(
      HidOutputReport outputReport);

    [MethodImpl]
    public extern IAsyncOperation<uint> SendFeatureReportAsync(
      HidFeatureReport featureReport);

    [MethodImpl]
    public extern IVectorView<HidBooleanControlDescription> GetBooleanControlDescriptions(
      HidReportType reportType,
      ushort usagePage,
      ushort usageId);

    [MethodImpl]
    public extern IVectorView<HidNumericControlDescription> GetNumericControlDescriptions(
      HidReportType reportType,
      ushort usagePage,
      ushort usageId);

    public extern event TypedEventHandler<HidDevice, HidInputReportReceivedEventArgs> InputReportReceived;

    [MethodImpl]
    public extern void Close();

    [Overload("GetDeviceSelector")]
    [MethodImpl]
    public static extern string GetDeviceSelector(ushort usagePage, ushort usageId);

    [Overload("GetDeviceSelectorVidPid")]
    [MethodImpl]
    public static extern string GetDeviceSelector(
      ushort usagePage,
      ushort usageId,
      ushort vendorId,
      ushort productId);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<HidDevice> FromIdAsync(
      string deviceId,
      FileAccessMode accessMode);
  }
}
