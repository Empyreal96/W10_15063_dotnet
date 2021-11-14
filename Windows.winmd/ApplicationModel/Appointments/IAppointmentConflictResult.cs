// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentConflictResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [ExclusiveTo(typeof (AppointmentConflictResult))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3587043518, 12079, 15229, 175, 10, 167, 226, 15, 58, 70, 227)]
  internal interface IAppointmentConflictResult
  {
    AppointmentConflictType Type { get; }

    DateTime Date { get; }
  }
}
