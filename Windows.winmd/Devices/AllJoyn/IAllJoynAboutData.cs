// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynAboutData
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [Guid(3853106944, 8098, 18489, 147, 239, 249, 223, 64, 72, 144, 247)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AllJoynAboutData))]
  internal interface IAllJoynAboutData
  {
    bool IsEnabled { get; set; }

    string DefaultAppName { get; set; }

    IMap<string, string> AppNames { get; }

    IReference<global::Windows.Foundation.DateTime> DateOfManufacture { get; set; }

    string DefaultDescription { get; set; }

    IMap<string, string> Descriptions { get; }

    string DefaultManufacturer { get; set; }

    IMap<string, string> Manufacturers { get; }

    string ModelNumber { get; set; }

    string SoftwareVersion { get; set; }

    global::Windows.Foundation.Uri SupportUrl { get; set; }

    Guid AppId { get; set; }
  }
}
