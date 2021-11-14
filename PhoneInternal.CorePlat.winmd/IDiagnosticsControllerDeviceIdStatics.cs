// Decompiled with JetBrains decompiler
// Type: PhoneInternal.CorePlat.Diagnostics.IDiagnosticsControllerDeviceIdStatics
// Assembly: PhoneInternal.CorePlat, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 567D0613-1791-46D6-BCA3-107C5D9EF3FD
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.CorePlat.winmd

using Windows.Foundation.Metadata;

namespace PhoneInternal.CorePlat.Diagnostics
{
  [Version(100859904)]
  [Guid(3307179764, 7021, 16769, 162, 45, 128, 202, 72, 245, 255, 48)]
  [ExclusiveTo(typeof (DiagnosticsControllerDeviceId))]
  internal interface IDiagnosticsControllerDeviceIdStatics
  {
    string IMEI { get; }

    string DeviceUniqueId { get; }

    string DeviceReportingId { get; }
  }
}
