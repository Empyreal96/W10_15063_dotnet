// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynAboutDataView
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.Devices.AllJoyn
{
  [Guid(1747128607, 25106, 18740, 156, 72, 225, 156, 164, 152, 66, 136)]
  [ExclusiveTo(typeof (AllJoynAboutDataView))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAllJoynAboutDataView
  {
    int Status { get; }

    IMapView<string, object> Properties { get; }

    string AJSoftwareVersion { get; }

    Guid AppId { get; }

    IReference<global::Windows.Foundation.DateTime> DateOfManufacture { get; }

    Language DefaultLanguage { get; }

    string DeviceId { get; }

    string HardwareVersion { get; }

    string ModelNumber { get; }

    string SoftwareVersion { get; }

    IVectorView<Language> SupportedLanguages { get; }

    global::Windows.Foundation.Uri SupportUrl { get; }

    string AppName { get; }

    string Description { get; }

    string DeviceName { get; }

    string Manufacturer { get; }
  }
}
