// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentStoreChangeType
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AppointmentStoreChangeType
  {
    AppointmentCreated,
    AppointmentModified,
    AppointmentDeleted,
    ChangeTrackingLost,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] CalendarCreated,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] CalendarModified,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] CalendarDeleted,
  }
}
