// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynAboutDataView
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.Devices.AllJoyn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IAllJoynAboutDataViewStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class AllJoynAboutDataView : IAllJoynAboutDataView
  {
    public extern int Status { [MethodImpl] get; }

    public extern IMapView<string, object> Properties { [MethodImpl] get; }

    public extern string AJSoftwareVersion { [MethodImpl] get; }

    public extern Guid AppId { [MethodImpl] get; }

    public extern IReference<global::Windows.Foundation.DateTime> DateOfManufacture { [MethodImpl] get; }

    public extern Language DefaultLanguage { [MethodImpl] get; }

    public extern string DeviceId { [MethodImpl] get; }

    public extern string HardwareVersion { [MethodImpl] get; }

    public extern string ModelNumber { [MethodImpl] get; }

    public extern string SoftwareVersion { [MethodImpl] get; }

    public extern IVectorView<Language> SupportedLanguages { [MethodImpl] get; }

    public extern global::Windows.Foundation.Uri SupportUrl { [MethodImpl] get; }

    public extern string AppName { [MethodImpl] get; }

    public extern string Description { [MethodImpl] get; }

    public extern string DeviceName { [MethodImpl] get; }

    public extern string Manufacturer { [MethodImpl] get; }

    [RemoteAsync]
    [Overload("GetDataBySessionPortAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<AllJoynAboutDataView> GetDataBySessionPortAsync(
      string uniqueName,
      AllJoynBusAttachment busAttachment,
      ushort sessionPort);

    [Overload("GetDataBySessionPortWithLanguageAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<AllJoynAboutDataView> GetDataBySessionPortAsync(
      string uniqueName,
      AllJoynBusAttachment busAttachment,
      ushort sessionPort,
      Language language);
  }
}
