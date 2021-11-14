// Decompiled with JetBrains decompiler
// Type: PhoneInternal.CorePlat.Diagnostics.DiagnosticsControllerDeviceId
// Assembly: PhoneInternal.CorePlat, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 567D0613-1791-46D6-BCA3-107C5D9EF3FD
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.CorePlat.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace PhoneInternal.CorePlat.Diagnostics
{
  [Threading(ThreadingModel.Both)]
  [Version(100859904)]
  [Static(typeof (IDiagnosticsControllerDeviceIdStatics), 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DiagnosticsControllerDeviceId : IDiagnosticsControllerDeviceId
  {
    public static extern string IMEI { [MethodImpl] get; }

    public static extern string DeviceUniqueId { [MethodImpl] get; }

    public static extern string DeviceReportingId { [MethodImpl] get; }
  }
}
